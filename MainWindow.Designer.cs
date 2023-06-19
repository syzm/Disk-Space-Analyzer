namespace WinFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dirsTreeView = new System.Windows.Forms.TreeView();
            this.butSelect = new System.Windows.Forms.Button();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.MainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelect,
            this.menuCancel,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuSelect
            // 
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSelect.Size = new System.Drawing.Size(150, 22);
            this.menuSelect.Text = "Select";
            this.menuSelect.Click += new System.EventHandler(this.menuSelect_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Enabled = false;
            this.menuCancel.Name = "menuCancel";
            this.menuCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuCancel.Size = new System.Drawing.Size(150, 22);
            this.menuCancel.Text = "Cancel";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(150, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(525, 16);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dirsTreeView);
            this.splitContainer1.Panel1.Controls.Add(this.butSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabInfo);
            this.splitContainer1.Size = new System.Drawing.Size(784, 365);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 2;
            // 
            // dirsTreeView
            // 
            this.dirsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirsTreeView.Location = new System.Drawing.Point(3, 34);
            this.dirsTreeView.Name = "dirsTreeView";
            this.dirsTreeView.Size = new System.Drawing.Size(199, 328);
            this.dirsTreeView.TabIndex = 1;
            this.dirsTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.dirsTreeView_AfterExpand);
            this.dirsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirsTreeView_AfterSelect);
            // 
            // butSelect
            // 
            this.butSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelect.Location = new System.Drawing.Point(3, 3);
            this.butSelect.MaximumSize = new System.Drawing.Size(70, 25);
            this.butSelect.MinimumSize = new System.Drawing.Size(70, 25);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(70, 25);
            this.butSelect.TabIndex = 0;
            this.butSelect.Text = "Select...";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabDetails);
            this.tabInfo.Controls.Add(this.tabCharts);
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(0, 0);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(575, 365);
            this.tabInfo.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.InfoLabel);
            this.tabDetails.Location = new System.Drawing.Point(4, 24);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(567, 337);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(5, 20);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 15);
            this.InfoLabel.TabIndex = 0;
            // 
            // tabCharts
            // 
            this.tabCharts.Location = new System.Drawing.Point(4, 24);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharts.Size = new System.Drawing.Size(567, 337);
            this.tabCharts.TabIndex = 1;
            this.tabCharts.Text = "Charts";
            this.tabCharts.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(800, 448);
            this.Name = "MainWindow";
            this.Text = "Disk Space Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tabDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuSelect;
        private ToolStripMenuItem menuCancel;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem menuAbout;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private Button butSelect;
        private TreeView dirsTreeView;
        private TabControl tabInfo;
        private TabPage tabDetails;
        private TabPage tabCharts;
        private Label InfoLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private ToolStripProgressBar ProgressBar;
    }
}