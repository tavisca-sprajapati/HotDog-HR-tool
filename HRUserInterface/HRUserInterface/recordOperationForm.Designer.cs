namespace HRUserInterface
{
    partial class recordOperationForm
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
            this.searchSelectComboBox = new System.Windows.Forms.ComboBox();
            this.searchKeywordTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.showRecordBtn = new System.Windows.Forms.Button();
            this.recordShowDataGridView = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOperationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordShowDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchSelectComboBox
            // 
            this.searchSelectComboBox.FormattingEnabled = true;
            this.searchSelectComboBox.Items.AddRange(new object[] {
            "Name",
            "DOB",
            "Designation"});
            this.searchSelectComboBox.Location = new System.Drawing.Point(61, 35);
            this.searchSelectComboBox.Name = "searchSelectComboBox";
            this.searchSelectComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchSelectComboBox.TabIndex = 0;
            // 
            // searchKeywordTxtBox
            // 
            this.searchKeywordTxtBox.Location = new System.Drawing.Point(232, 36);
            this.searchKeywordTxtBox.Name = "searchKeywordTxtBox";
            this.searchKeywordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.searchKeywordTxtBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(384, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // showRecordBtn
            // 
            this.showRecordBtn.Location = new System.Drawing.Point(384, 86);
            this.showRecordBtn.Name = "showRecordBtn";
            this.showRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.showRecordBtn.TabIndex = 3;
            this.showRecordBtn.Text = "Show Record";
            this.showRecordBtn.UseVisualStyleBackColor = true;
            this.showRecordBtn.Click += new System.EventHandler(this.showRecordBtn_Click);
            // 
            // recordShowDataGridView
            // 
            this.recordShowDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordShowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.recordShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit});
            this.recordShowDataGridView.Location = new System.Drawing.Point(30, 147);
            this.recordShowDataGridView.Name = "recordShowDataGridView";
            this.recordShowDataGridView.ReadOnly = true;
            this.recordShowDataGridView.Size = new System.Drawing.Size(582, 308);
            this.recordShowDataGridView.TabIndex = 4;
            this.recordShowDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordShowDataGridView_CellContentClick);
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomePageToolStripMenuItem,
            this.registrationPageToolStripMenuItem,
            this.dataOperationPageToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // welcomePageToolStripMenuItem
            // 
            this.welcomePageToolStripMenuItem.Name = "welcomePageToolStripMenuItem";
            this.welcomePageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.welcomePageToolStripMenuItem.Text = "Welcome Page";
            this.welcomePageToolStripMenuItem.Click += new System.EventHandler(this.welcomePageToolStripMenuItem_Click);
            // 
            // registrationPageToolStripMenuItem
            // 
            this.registrationPageToolStripMenuItem.Name = "registrationPageToolStripMenuItem";
            this.registrationPageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrationPageToolStripMenuItem.Text = "Registration Page";
            this.registrationPageToolStripMenuItem.Click += new System.EventHandler(this.registrationPageToolStripMenuItem_Click);
            // 
            // dataOperationPageToolStripMenuItem
            // 
            this.dataOperationPageToolStripMenuItem.Name = "dataOperationPageToolStripMenuItem";
            this.dataOperationPageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.dataOperationPageToolStripMenuItem.Text = "Data Operation Page";
            this.dataOperationPageToolStripMenuItem.Click += new System.EventHandler(this.dataOperationPageToolStripMenuItem_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(61, 85);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(121, 23);
            this.DownloadBtn.TabIndex = 6;
            this.DownloadBtn.Text = "download file";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // recordOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 467);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.recordShowDataGridView);
            this.Controls.Add(this.showRecordBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchKeywordTxtBox);
            this.Controls.Add(this.searchSelectComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "recordOperationForm";
            this.Text = "recordOperationForm";
            ((System.ComponentModel.ISupportInitialize)(this.recordShowDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchSelectComboBox;
        private System.Windows.Forms.TextBox searchKeywordTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button showRecordBtn;
        private System.Windows.Forms.DataGridView recordShowDataGridView;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOperationPageToolStripMenuItem;
        private System.Windows.Forms.Button DownloadBtn;
    }
}