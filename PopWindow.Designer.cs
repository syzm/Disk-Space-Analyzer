namespace WinFormsApp1
{
    partial class PopWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.IndRadioButton = new System.Windows.Forms.RadioButton();
            this.FolderRadioButton = new System.Windows.Forms.RadioButton();
            this.DiskListView = new System.Windows.Forms.ListView();
            this.diskName = new System.Windows.Forms.ColumnHeader();
            this.totalSpace = new System.Windows.Forms.ColumnHeader();
            this.FreeSpace = new System.Windows.Forms.ColumnHeader();
            this.PercentBar = new System.Windows.Forms.ColumnHeader();
            this.PercentUsed = new System.Windows.Forms.ColumnHeader();
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Location = new System.Drawing.Point(22, 19);
            this.AllRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(132, 24);
            this.AllRadioButton.TabIndex = 0;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "&All Local Drives";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            // 
            // IndRadioButton
            // 
            this.IndRadioButton.AutoSize = true;
            this.IndRadioButton.Location = new System.Drawing.Point(22, 52);
            this.IndRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IndRadioButton.Name = "IndRadioButton";
            this.IndRadioButton.Size = new System.Drawing.Size(140, 24);
            this.IndRadioButton.TabIndex = 1;
            this.IndRadioButton.TabStop = true;
            this.IndRadioButton.Text = "&Individual Drives";
            this.IndRadioButton.UseVisualStyleBackColor = true;
            // 
            // FolderRadioButton
            // 
            this.FolderRadioButton.AutoSize = true;
            this.FolderRadioButton.Location = new System.Drawing.Point(22, 235);
            this.FolderRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderRadioButton.Name = "FolderRadioButton";
            this.FolderRadioButton.Size = new System.Drawing.Size(86, 24);
            this.FolderRadioButton.TabIndex = 2;
            this.FolderRadioButton.TabStop = true;
            this.FolderRadioButton.Text = "A &Folder";
            this.FolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiskListView
            // 
            this.DiskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.diskName,
            this.totalSpace,
            this.FreeSpace,
            this.PercentBar,
            this.PercentUsed});
            this.DiskListView.FullRowSelect = true;
            this.DiskListView.Location = new System.Drawing.Point(22, 85);
            this.DiskListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiskListView.Name = "DiskListView";
            this.DiskListView.Scrollable = false;
            this.DiskListView.Size = new System.Drawing.Size(517, 140);
            this.DiskListView.TabIndex = 3;
            this.DiskListView.UseCompatibleStateImageBehavior = false;
            this.DiskListView.View = System.Windows.Forms.View.Details;
            this.DiskListView.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.DiskListView_ColumnWidthChanged);
            this.DiskListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.DiskListView_ColumnWidthChanging);
            this.DiskListView.SelectedIndexChanged += new System.EventHandler(this.DiskListView_SelectedIndexChanged);
            // 
            // diskName
            // 
            this.diskName.Text = "Name";
            this.diskName.Width = 44;
            // 
            // totalSpace
            // 
            this.totalSpace.Text = "Total";
            this.totalSpace.Width = 38;
            // 
            // FreeSpace
            // 
            this.FreeSpace.Text = "Free";
            this.FreeSpace.Width = 34;
            // 
            // PercentBar
            // 
            this.PercentBar.Text = "Used/Total";
            this.PercentBar.Width = 90;
            // 
            // PercentUsed
            // 
            this.PercentUsed.Text = "Used/Total";
            this.PercentUsed.Width = 70;
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(471, 267);
            this.FolderSelectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(69, 31);
            this.FolderSelectButton.TabIndex = 4;
            this.FolderSelectButton.Text = "...";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(471, 305);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(69, 31);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(395, 305);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(69, 31);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "SuggestAppend"});
            this.FolderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FolderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.FolderTextBox.Location = new System.Drawing.Point(22, 268);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(442, 27);
            this.FolderTextBox.TabIndex = 7;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            // 
            // PopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 337);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FolderSelectButton);
            this.Controls.Add(this.DiskListView);
            this.Controls.Add(this.FolderRadioButton);
            this.Controls.Add(this.IndRadioButton);
            this.Controls.Add(this.AllRadioButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(569, 384);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(569, 384);
            this.Name = "PopWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Disk or Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton AllRadioButton;
        private RadioButton IndRadioButton;
        private RadioButton FolderRadioButton;
        private ListView DiskListView;
        private Button FolderSelectButton;
        private Button CancelButton;
        private Button OKButton;
        private TextBox FolderTextBox;
        private ColumnHeader diskName;
        private ColumnHeader totalSpace;
        private ColumnHeader FreeSpace;
        private ColumnHeader PercentUsed;
        private ColumnHeader PercentBar;
    }
}