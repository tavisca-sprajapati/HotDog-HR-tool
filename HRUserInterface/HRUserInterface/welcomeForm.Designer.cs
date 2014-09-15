namespace HRUserInterface
{
    partial class welcomeForm
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
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.viewRecordBtn = new System.Windows.Forms.Button();
            this.notificationBtn = new System.Windows.Forms.Button();
            this.notificationDataGridView = new System.Windows.Forms.DataGridView();
            this.headingLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordOperationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(32, 146);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.addRecordBtn.TabIndex = 0;
            this.addRecordBtn.Text = "Add Records";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.addRecordBtn_Click);
            // 
            // viewRecordBtn
            // 
            this.viewRecordBtn.Location = new System.Drawing.Point(32, 255);
            this.viewRecordBtn.Name = "viewRecordBtn";
            this.viewRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.viewRecordBtn.TabIndex = 1;
            this.viewRecordBtn.Text = "View Record";
            this.viewRecordBtn.UseVisualStyleBackColor = true;
            this.viewRecordBtn.Click += new System.EventHandler(this.viewRecordBtn_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.Location = new System.Drawing.Point(32, 361);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(75, 23);
            this.notificationBtn.TabIndex = 2;
            this.notificationBtn.Text = "Notification";
            this.notificationBtn.UseVisualStyleBackColor = true;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // notificationDataGridView
            // 
            this.notificationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationDataGridView.Location = new System.Drawing.Point(136, 169);
            this.notificationDataGridView.Name = "notificationDataGridView";
            this.notificationDataGridView.Size = new System.Drawing.Size(374, 276);
            this.notificationDataGridView.TabIndex = 3;
            this.notificationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notificationDataGridView_CellContentClick);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Location = new System.Drawing.Point(217, 42);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(105, 13);
            this.headingLabel.TabIndex = 4;
            this.headingLabel.Text = "Welcome to Tavisca";
            this.headingLabel.Click += new System.EventHandler(this.headingLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomePageToolStripMenuItem,
            this.registarationPageToolStripMenuItem,
            this.recordOperationPageToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // welcomePageToolStripMenuItem
            // 
            this.welcomePageToolStripMenuItem.Name = "welcomePageToolStripMenuItem";
            this.welcomePageToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.welcomePageToolStripMenuItem.Text = "Welcome Page";
            this.welcomePageToolStripMenuItem.Click += new System.EventHandler(this.welcomePageToolStripMenuItem_Click);
            // 
            // registarationPageToolStripMenuItem
            // 
            this.registarationPageToolStripMenuItem.Name = "registarationPageToolStripMenuItem";
            this.registarationPageToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registarationPageToolStripMenuItem.Text = "Registaration Page";
            this.registarationPageToolStripMenuItem.Click += new System.EventHandler(this.registarationPageToolStripMenuItem_Click);
            // 
            // recordOperationPageToolStripMenuItem
            // 
            this.recordOperationPageToolStripMenuItem.Name = "recordOperationPageToolStripMenuItem";
            this.recordOperationPageToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.recordOperationPageToolStripMenuItem.Text = "Record Operation Page";
            this.recordOperationPageToolStripMenuItem.Click += new System.EventHandler(this.recordOperationPageToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(136, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 44);
            this.panel1.TabIndex = 6;
            // 
            // welcomeForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.notificationDataGridView);
            this.Controls.Add(this.notificationBtn);
            this.Controls.Add(this.viewRecordBtn);
            this.Controls.Add(this.addRecordBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "welcomeForm";
            this.Text = "welcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Button viewRecordBtn;
        private System.Windows.Forms.Button notificationBtn;
        private System.Windows.Forms.DataGridView notificationDataGridView;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordOperationPageToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}