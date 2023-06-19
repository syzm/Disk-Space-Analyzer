using System.Collections.Concurrent;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class MainWindow : Form
    {
        private List<DriveInfo> drives;
        private bool isBegScreen;
        private ConcurrentDictionary<string, (long, int, int, int, DateTime)> checkedPaths;
        private bool skonczyl;
        private DirectoryInfo parent;
        private int unique;

        public MainWindow()
        {
            skonczyl = false;
            InitializeComponent();
            isBegScreen = true;
            checkedPaths = new ConcurrentDictionary<string, (long, int, int, int, DateTime)>();
        }

        //https://codehill.com/2013/06/list-drives-and-folders-in-a-treeview-using-c/?fbclid=IwAR1PnmrL-g7VeDReei-3rLaO5xVVNo24b55KgeSGIPJ_DoF7dPcaGYT2Qss
        private void Form1_Load(object sender, EventArgs e)
        {
            drives = new List<DriveInfo>();
            //get a list of the drives
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    drives.Add(drive);
                    TreeNode node = new TreeNode(drive.Name, 2, 2);
                    node.Tag = drive.Name;
                    node.Nodes.Add("...");
                    dirsTreeView.Nodes.Add(node);
                }
            }

            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            ProgressBar.Value = 0;
            menuCancel.Enabled = true;
            backgroundWorker.RunWorkerAsync();
        }

        //https://codehill.com/2013/06/list-drives-and-folders-in-a-treeview-using-c/?fbclid=IwAR1PnmrL-g7VeDReei-3rLaO5xVVNo24b55KgeSGIPJ_DoF7dPcaGYT2Qss
        private void butSelect_Click(object sender, EventArgs e)
        {
            using (var popWindow = new PopWindow())
            {
                var result = popWindow.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if(Directory.Exists(popWindow.directory))
                    {
                        isBegScreen = false;
                        dirsTreeView.Nodes.Clear();
                        string name = new DirectoryInfo(popWindow.directory).Name;
                        TreeNode node = new TreeNode(name, 2, 2);
                        node.Tag = popWindow.directory;
                        node.Nodes.Add("...");
                        dirsTreeView.Nodes.Add(node);
                        dirsTreeView.SelectedNode = node;
                    }
                    else
                    {
                        if(popWindow.result == "all")
                        {
                            if(!isBegScreen)
                            {
                                dirsTreeView.Nodes.Clear();
                                foreach (var drive in drives)
                                {

                                        TreeNode node = new TreeNode(drive.Name, 2, 2);
                                        node.Tag = drive.Name;
                                        node.Nodes.Add("...");
                                        dirsTreeView.Nodes.Add(node);
                                }
                                isBegScreen = true;
                            }
                            else
                            {
                                dirsTreeView.CollapseAll();
                            }
                        }
                        else
                        {
                            dirsTreeView.Nodes.Clear();
                            isBegScreen = false;
                        }
                    }
                }
            }
        }

        private void menuSelect_Click(object sender, EventArgs e)
        {
            // using same function for Select button and Select menu item
            butSelect_Click(sender, e);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //https://codehill.com/2013/06/list-drives-and-folders-in-a-treeview-using-c/?fbclid=IwAR1PnmrL-g7VeDReei-3rLaO5xVVNo24b55KgeSGIPJ_DoF7dPcaGYT2Qss
        private void dirsTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    try
                    {
                        string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                        foreach (string dir in dirs)
                        {
                            DirectoryInfo di = new DirectoryInfo(dir);
                            TreeNode node = new TreeNode(di.Name);

                            try
                            {
                                //keep the directory's full path in the tag for use later
                                node.Tag = dir;

                                //if the directory has sub directories add the place holder
                                if (di.GetDirectories().Count() > 0)
                                    node.Nodes.Add(null, "...", 0, 0);

                                if (di.GetFiles().Count() > 3)
                                {
                                    TreeNode filesNode = new TreeNode("<Files>");
                                    foreach (string file in Directory.GetFiles(dir))
                                    {
                                        filesNode.Nodes.Add(new TreeNode(Path.GetFileName(file)));
                                    }
                                    node.Nodes.Add(filesNode);
                                }
                                else
                                {
                                    foreach (string file in Directory.GetFiles(dir))
                                    {
                                        node.Nodes.Add(new TreeNode(Path.GetFileName(file)));
                                    }
                                }
                            }
                            catch (UnauthorizedAccessException)
                            {
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "DirectoryLister",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                e.Node.Nodes.Add(node);
                            }
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                    }
                }
            }
        }

        private void dirsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string fullPath = dirsTreeView.SelectedNode.Tag as string;
            if (fullPath != null)
            {
                InfoLabel.Text = "Full path: " + fullPath;

                if (backgroundWorker.IsBusy)
                {
                    backgroundWorker.CancelAsync();
                }

                while (backgroundWorker.IsBusy)
                {
                    Application.DoEvents();
                }

                skonczyl = false;
                ProgressBar.Value = 0;
                parent = new DirectoryInfo(fullPath);
                menuCancel.Enabled = true;
                if (checkedPaths.ContainsKey(fullPath))
                {
                    ProgressBar.Value = 100;
                }
                backgroundWorker.RunWorkerAsync(argument: fullPath);
                while (backgroundWorker.IsBusy)
                {
                    Application.DoEvents();
                }
                if (skonczyl && (dirsTreeView.SelectedNode.Tag as string) == fullPath && checkedPaths.ContainsKey(fullPath))
                {
                    if (checkedPaths[fullPath].Item5 != DateTime.MinValue)
                    {
                        InfoLabel.Text += ("\nSize: " + ToBytesCount(checkedPaths[fullPath].Item1).ToString());
                        InfoLabel.Text += "\nItems: " + checkedPaths[fullPath].Item2.ToString();
                        InfoLabel.Text += "\nFiles: " + checkedPaths[fullPath].Item3.ToString();
                        InfoLabel.Text += "\nSubdirs: " + checkedPaths[fullPath].Item4.ToString();
                        InfoLabel.Text += "\nLast change: " + checkedPaths[fullPath].Item5.ToString();
                    }
                }
            }
        }

        // https://stackoverflow.com/questions/468119/whats-the-best-way-to-calculate-the-size-of-a-directory-in-net
        public (long size, int fileCount, int Amount, int subDirCount, DateTime lastChangeDate) DirInfos(string path)
        {
            long size = 0;
            int amount = 0;
            int fileCount = 0;
            int subDirCount = 0;
            DateTime lastChangeDate = DateTime.MinValue;
            

            var fis = Directory.EnumerateFiles(
                path, "*", new EnumerationOptions {IgnoreInaccessible = true});

            foreach (var f in fis)
            {
                FileInfo fi = new FileInfo(f);
                if (backgroundWorker.CancellationPending)
                {
                    return (0, 0, 0, 0, DateTime.MinValue);
                }
                size += fi.Length;
                fileCount++;
                if (fi.LastWriteTime > lastChangeDate)
                {
                    lastChangeDate = fi.LastWriteTime;
                }
            }


            var dis = Directory.EnumerateDirectories(
                path, "*", new EnumerationOptions { IgnoreInaccessible = true });
            int count = dis.Count();
            bool isfirst = true;

            foreach (var d in dis)
            {
                DirectoryInfo di = new DirectoryInfo(d);
                if (di.Parent.ToString() == parent.ToString())
                {
                    isfirst = true;
                }
                else
                {
                    isfirst = false;
                }
                if (backgroundWorker.CancellationPending)
                {
                    return (0, 0, 0, 0, DateTime.MinValue);
                }
                (long subdirectorySize, int subdirectoryFileCount, int sth, int subdirectorySubdirectoryCount, DateTime subdirectoryLastChangeDate) = DirInfos(di.FullName);
                size += subdirectorySize;
                fileCount += subdirectoryFileCount;
                subDirCount += subdirectorySubdirectoryCount;
                subDirCount++;
                if (di.LastWriteTime > lastChangeDate)
                {
                    lastChangeDate = di.LastWriteTime;
                }

                if (isfirst)
                {
                    unique++;
                    backgroundWorker.ReportProgress((int)(100.0 * (double)unique / (double)count));
                }
            }

            amount = fileCount + subDirCount;

            return (size, amount, fileCount, subDirCount, lastChangeDate);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker.CancellationPending)
            {
                return;
            }

            string tmp = e.Argument as string;

            if (tmp != null)
            {
                if (!checkedPaths.ContainsKey(tmp))
                {
                    unique = 0;
                    checkedPaths[tmp] = DirInfos(tmp);
                }
                else
                {
                    if (checkedPaths[tmp].Item2 == 0)
                    {
                        checkedPaths.TryRemove(tmp, out _);
                        unique = 0;
                        checkedPaths[tmp] = DirInfos(tmp);
                    }
                }
            }
            else
            {
                foreach (var drive in drives)
                {
                    parent = new DirectoryInfo(drive.Name);
                    unique = 0;
                    checkedPaths[drive.Name] = DirInfos(drive.Name);
                }
            }

        }
        //https://stackoverflow.com/questions/281640/how-do-i-get-a-human-readable-file-size-in-bytes-abbreviation-using-net
        public static string ToBytesCount(long bytes)
        {
            int unit = 1024;
            string unitStr = "B";
            if (bytes < unit)
            {
                return string.Format("{0} {1}", bytes, unitStr);
            }
            int exp = (int)(Math.Log(bytes) / Math.Log(unit));
            return string.Format("{0:##.##} {1}{2}", bytes / Math.Pow(unit, exp), "KMGTPEZY"[exp - 1], unitStr);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            skonczyl = true;
            if (e.Cancelled)
            {
                InfoLabel.Text = "";
            }
            menuCancel.Enabled = false;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            menuCancel.Enabled = false;
            InfoLabel.Text = "";
        }
    }
    }