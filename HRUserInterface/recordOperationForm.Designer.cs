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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchSelectComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.showRecordBtn = new System.Windows.Forms.Button();
            this.recordShowDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOperationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.EnterKeywordLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.DOBTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DOJTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.recordShowDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchSelectComboBox
            // 
            this.searchSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchSelectComboBox.FormattingEnabled = true;
            this.searchSelectComboBox.Items.AddRange(new object[] {
            "--select--",
            "First Name",
            "Employee ID",
            "By Team",
            "Email Id",
            "DOB",
            "Date Of Joining",
            "Designation"});
            this.searchSelectComboBox.Location = new System.Drawing.Point(93, 224);
            this.searchSelectComboBox.Name = "searchSelectComboBox";
            this.searchSelectComboBox.Size = new System.Drawing.Size(100, 21);
            this.searchSelectComboBox.TabIndex = 0;
            this.searchSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.searchSelectComboBox_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(93, 301);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // showRecordBtn
            // 
            this.showRecordBtn.Location = new System.Drawing.Point(93, 176);
            this.showRecordBtn.Name = "showRecordBtn";
            this.showRecordBtn.Size = new System.Drawing.Size(100, 23);
            this.showRecordBtn.TabIndex = 3;
            this.showRecordBtn.Text = "Show Record";
            this.showRecordBtn.UseVisualStyleBackColor = true;
            this.showRecordBtn.Click += new System.EventHandler(this.showRecordBtn_Click);
            // 
            // recordShowDataGridView
            // 
            this.recordShowDataGridView.AllowUserToAddRows = false;
            this.recordShowDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordShowDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.recordShowDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordShowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.recordShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordShowDataGridView.Location = new System.Drawing.Point(213, 160);
            this.recordShowDataGridView.Name = "recordShowDataGridView";
            this.recordShowDataGridView.ReadOnly = true;
            this.recordShowDataGridView.RowHeadersVisible = false;
            this.recordShowDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordShowDataGridView.Size = new System.Drawing.Size(469, 265);
            this.recordShowDataGridView.TabIndex = 4;
            this.recordShowDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordShowDataGridView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
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
            this.DownloadBtn.Location = new System.Drawing.Point(94, 369);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(100, 23);
            this.DownloadBtn.TabIndex = 6;
            this.DownloadBtn.Text = "Download file";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 116);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HRUserInterface.Properties.Resources.Tavisca_logo_180;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(213, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 39);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 77);
            this.panel3.TabIndex = 9;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(11, 227);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(75, 13);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "Search Option";
            // 
            // EnterKeywordLbl
            // 
            this.EnterKeywordLbl.AutoSize = true;
            this.EnterKeywordLbl.Location = new System.Drawing.Point(12, 267);
            this.EnterKeywordLbl.Name = "EnterKeywordLbl";
            this.EnterKeywordLbl.Size = new System.Drawing.Size(76, 13);
            this.EnterKeywordLbl.TabIndex = 11;
            this.EnterKeywordLbl.Text = "Enter Keyword";
            this.EnterKeywordLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Information Page";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(94, 340);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(94, 264);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchTextbox.TabIndex = 13;
            this.searchTextbox.Visible = false;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // DOBTimePicker
            // 
            this.DOBTimePicker.Location = new System.Drawing.Point(15, 260);
            this.DOBTimePicker.Name = "DOBTimePicker";
            this.DOBTimePicker.Size = new System.Drawing.Size(179, 20);
            this.DOBTimePicker.TabIndex = 14;
            this.DOBTimePicker.Visible = false;
            // 
            // DOJTimePicker
            // 
            this.DOJTimePicker.Location = new System.Drawing.Point(15, 261);
            this.DOJTimePicker.Name = "DOJTimePicker";
            this.DOJTimePicker.Size = new System.Drawing.Size(175, 20);
            this.DOJTimePicker.TabIndex = 15;
            this.DOJTimePicker.Visible = false;
            // 
            // recordOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 554);
            this.Controls.Add(this.DOJTimePicker);
            this.Controls.Add(this.DOBTimePicker);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterKeywordLbl);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.recordShowDataGridView);
            this.Controls.Add(this.showRecordBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchSelectComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "recordOperationForm";
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.recordOperationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordShowDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchSelectComboBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button showRecordBtn;
        private System.Windows.Forms.DataGridView recordShowDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOperationPageToolStripMenuItem;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label EnterKeywordLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.DateTimePicker DOBTimePicker;
        private System.Windows.Forms.DateTimePicker DOJTimePicker;
    }
}