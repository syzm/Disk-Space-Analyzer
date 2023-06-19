namespace WinFormsApp1
{
    public partial class PopWindow : Form
    {
        public string? directory { get; set; }
        public string? result { get; set; }
        public List<DriveInfo> disks { get; set; }
        public PopWindow()
        {
            InitializeComponent();

            DiskListView.Columns[0].Width = -2;
            DiskListView.Columns[1].Width = 70;
            DiskListView.Columns[2].Width = 70;
            DiskListView.Columns[3].Width = -2;
            DiskListView.Columns[4].Width = -2;
            disks = new List<DriveInfo>();
            int i = 0;
            // getting data for the ListView
            foreach (var drive in DriveInfo.GetDrives())
            {
                if(drive.IsReady)
                {
                    disks.Add(drive);
                    AddLVItem(drive, i);
                    i++;
                }    
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            FolderRadioButton.PerformClick();

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = false;

            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = folderBrowser.SelectedPath;
                FolderTextBox.Text = selectedPath;
            }
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            FolderRadioButton.PerformClick();
            if (Directory.Exists(FolderTextBox.Text))
            {
                FolderTextBox.ForeColor = Color.Black;
            }
            else
            {
                FolderTextBox.ForeColor = Color.Red;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(AllRadioButton.Checked)
            {
                result = "all";
                directory = null;
            }

            else if (IndRadioButton.Checked) 
            {
                result = null;
                int index = 0;
                if (DiskListView.SelectedItems.Count > 0)
                {
                    index = DiskListView.SelectedIndices[0];
                    ListViewItem selectedItem = DiskListView.Items[index];
                    directory = selectedItem.SubItems[0].Text;
                }
                else
                {
                    directory = null;
                }
            }

            else if (FolderRadioButton.Checked) 
            {
                directory = FolderTextBox.Text;
                result = null;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DiskListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndRadioButton.PerformClick();
        }

        // https://stackoverflow.com/questions/39181805/accessing-progressbar-in-listview
        private void AddLVItem(DriveInfo drive, int i)
        {
            double totalSpace = (double)drive.TotalSize / (1024 * 1024 * 1024);
            double freeSpace = (double)drive.AvailableFreeSpace / (1024 * 1024 * 1024);
            double usagePercentage = 100 - (100 * freeSpace / totalSpace);

            ListViewItem item = new ListViewItem(drive.Name);
            
            item.SubItems.Add($"{totalSpace:F1} GB");
            item.SubItems.Add($"{freeSpace:F1} GB");
            item.SubItems.Add("");
            item.SubItems.Add($"{usagePercentage:F2}%");
            DiskListView.Items.Add(item);

            // SubItem bounds has a bug so I have to do it like this
            Rectangle r = item.Bounds;
            int subitemX = r.X; 
            for (int j = 0; j < 3; j++)
            {
                subitemX += DiskListView.Columns[j].Width;
            }


            ProgressBar pb = new ProgressBar();

            pb.Visible = true;
            pb.SetBounds(subitemX, r.Y, DiskListView.Columns[3].Width, r.Height);
            pb.Minimum = 0;
            pb.Maximum = 10000;
            pb.Value = (int)(usagePercentage * 100);
            DiskListView.Controls.Add(pb);

        }

        private void DiskListView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            // Use it only for later resizing
            if (this.IsHandleCreated)
            {
                int i = 0;
                DiskListView.Items.Clear();
                DiskListView.Controls.Clear();
                foreach (var drive in disks)
                {
                    AddLVItem(drive, i);
                    i++;
                }
            }
        }

        private void DiskListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Use it only for later resizing
            if (this.IsHandleCreated)
            {
                int i = 0;
                DiskListView.Items.Clear();
                DiskListView.Controls.Clear();
                foreach (var drive in disks)
                {
                    AddLVItem(drive, i);
                    i++;
                }
            }
        }
    }
}
