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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordOperationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.publishButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.publishRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notificationlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventCheckerGroupBox = new System.Windows.Forms.GroupBox();
            this.notificationCheckButton = new System.Windows.Forms.Button();
            this.notificationDaysTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notificationdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.eventCheckerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(24, 183);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(114, 23);
            this.addRecordBtn.TabIndex = 0;
            this.addRecordBtn.Text = "Add Employee";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.addRecordBtn_Click);
            // 
            // viewRecordBtn
            // 
            this.viewRecordBtn.Location = new System.Drawing.Point(23, 231);
            this.viewRecordBtn.Name = "viewRecordBtn";
            this.viewRecordBtn.Size = new System.Drawing.Size(114, 23);
            this.viewRecordBtn.TabIndex = 1;
            this.viewRecordBtn.Text = "View Record";
            this.viewRecordBtn.UseVisualStyleBackColor = true;
            this.viewRecordBtn.Click += new System.EventHandler(this.viewRecordBtn_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.Location = new System.Drawing.Point(24, 279);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(114, 23);
            this.notificationBtn.TabIndex = 2;
            this.notificationBtn.Text = "Todays Notification";
            this.notificationBtn.UseVisualStyleBackColor = true;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 64);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.publishButton);
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Controls.Add(this.publishRichTextBox);
            this.panel3.Location = new System.Drawing.Point(230, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 156);
            this.panel3.TabIndex = 8;
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(112, 120);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(96, 23);
            this.publishButton.TabIndex = 2;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalExtent = 4;
            this.checkedListBox1.Items.AddRange(new object[] {
            "All",
            "CLTS",
            "Rovia",
            "Phoenix"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 120);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(91, 75);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // publishRichTextBox
            // 
            this.publishRichTextBox.Location = new System.Drawing.Point(0, 6);
            this.publishRichTextBox.Name = "publishRichTextBox";
            this.publishRichTextBox.Size = new System.Drawing.Size(551, 96);
            this.publishRichTextBox.TabIndex = 0;
            this.publishRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 116);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HRUserInterface.Properties.Resources.Tavisca_logo_180;
            this.pictureBox1.Location = new System.Drawing.Point(32, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // notificationlistBox
            // 
            this.notificationlistBox.BackColor = System.Drawing.SystemColors.Window;
            this.notificationlistBox.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.notificationlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationlistBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationlistBox.ForeColor = System.Drawing.Color.DarkRed;
            this.notificationlistBox.FormattingEnabled = true;
            this.notificationlistBox.ItemHeight = 18;
            this.notificationlistBox.Location = new System.Drawing.Point(0, 0);
            this.notificationlistBox.Name = "notificationlistBox";
            this.notificationlistBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.notificationlistBox.Size = new System.Drawing.Size(551, 127);
            this.notificationlistBox.TabIndex = 8;
            this.notificationlistBox.SelectedIndexChanged += new System.EventHandler(this.notificationlistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Home Page";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.notificationlistBox);
            this.panel4.Location = new System.Drawing.Point(230, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(551, 127);
            this.panel4.TabIndex = 8;
            // 
            // eventCheckerGroupBox
            // 
            this.eventCheckerGroupBox.Controls.Add(this.notificationCheckButton);
            this.eventCheckerGroupBox.Controls.Add(this.notificationDaysTextBox);
            this.eventCheckerGroupBox.Controls.Add(this.label3);
            this.eventCheckerGroupBox.Controls.Add(this.label2);
            this.eventCheckerGroupBox.Location = new System.Drawing.Point(15, 321);
            this.eventCheckerGroupBox.Name = "eventCheckerGroupBox";
            this.eventCheckerGroupBox.Size = new System.Drawing.Size(194, 129);
            this.eventCheckerGroupBox.TabIndex = 10;
            this.eventCheckerGroupBox.TabStop = false;
            this.eventCheckerGroupBox.Text = "Check upcoming Events";
            // 
            // notificationCheckButton
            // 
            this.notificationCheckButton.Location = new System.Drawing.Point(57, 100);
            this.notificationCheckButton.Name = "notificationCheckButton";
            this.notificationCheckButton.Size = new System.Drawing.Size(75, 23);
            this.notificationCheckButton.TabIndex = 3;
            this.notificationCheckButton.Text = "Check";
            this.notificationCheckButton.UseVisualStyleBackColor = true;
            this.notificationCheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // notificationDaysTextBox
            // 
            this.notificationDaysTextBox.Location = new System.Drawing.Point(87, 74);
            this.notificationDaysTextBox.Name = "notificationDaysTextBox";
            this.notificationDaysTextBox.Size = new System.Drawing.Size(101, 20);
            this.notificationDaysTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "number of Days";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Date";
            // 
            // notificationdatePicker
            // 
            this.notificationdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.notificationdatePicker.Location = new System.Drawing.Point(102, 353);
            this.notificationdatePicker.Name = "notificationdatePicker";
            this.notificationdatePicker.Size = new System.Drawing.Size(101, 20);
            this.notificationdatePicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notifications";
            // 
            // welcomeForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notificationdatePicker);
            this.Controls.Add(this.eventCheckerGroupBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notificationBtn);
            this.Controls.Add(this.viewRecordBtn);
            this.Controls.Add(this.addRecordBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "welcomeForm";
            this.Text = "Home Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.eventCheckerGroupBox.ResumeLayout(false);
            this.eventCheckerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Button viewRecordBtn;
        private System.Windows.Forms.Button notificationBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordOperationPageToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox notificationlistBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox eventCheckerGroupBox;
        private System.Windows.Forms.TextBox notificationDaysTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker notificationdatePicker;
        private System.Windows.Forms.Button notificationCheckButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RichTextBox publishRichTextBox;
        private System.Windows.Forms.Button publishButton;
    }
}