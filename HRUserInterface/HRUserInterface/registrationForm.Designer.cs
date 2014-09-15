namespace HRUserInterface
{
    partial class registrationForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.joiningDateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.designationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.middleNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.prefixComboBox = new System.Windows.Forms.ComboBox();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.joiningDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.designationTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOperationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imagePathTxtBox = new System.Windows.Forms.TextBox();
            this.browseImageBtn = new System.Windows.Forms.Button();
            this.submitTxt = new System.Windows.Forms.Button();
            this.cancelTxt = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(289, 77);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(69, 13);
            this.middleNameLabel.TabIndex = 1;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(32, 145);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(289, 145);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(33, 13);
            this.prefixLabel.TabIndex = 3;
            this.prefixLabel.Text = "Prefix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // joiningDateLabel
            // 
            this.joiningDateLabel.AutoSize = true;
            this.joiningDateLabel.Location = new System.Drawing.Point(289, 222);
            this.joiningDateLabel.Name = "joiningDateLabel";
            this.joiningDateLabel.Size = new System.Drawing.Size(66, 13);
            this.joiningDateLabel.TabIndex = 5;
            this.joiningDateLabel.Text = "Joining Date";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(32, 293);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Gender";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(289, 293);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email ID";
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.Location = new System.Drawing.Point(32, 355);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(63, 13);
            this.designationLabel.TabIndex = 8;
            this.designationLabel.Text = "Designation";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(32, 418);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(117, 68);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 11;
            // 
            // middleNameTxtBox
            // 
            this.middleNameTxtBox.Location = new System.Drawing.Point(388, 68);
            this.middleNameTxtBox.Name = "middleNameTxtBox";
            this.middleNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTxtBox.TabIndex = 12;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(117, 138);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxtBox.TabIndex = 13;
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.FormattingEnabled = true;
            this.prefixComboBox.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss."});
            this.prefixComboBox.Location = new System.Drawing.Point(388, 138);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(89, 21);
            this.prefixComboBox.TabIndex = 14;
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.DOBdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBdateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DOBdateTimePicker.Location = new System.Drawing.Point(117, 214);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.DOBdateTimePicker.TabIndex = 15;
            // 
            // joiningDateDateTimePicker
            // 
            this.joiningDateDateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.joiningDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.joiningDateDateTimePicker.Location = new System.Drawing.Point(388, 214);
            this.joiningDateDateTimePicker.Name = "joiningDateDateTimePicker";
            this.joiningDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.joiningDateDateTimePicker.TabIndex = 16;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(117, 291);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 17;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(181, 291);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 18;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(388, 286);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.emailTxtBox.TabIndex = 19;
            // 
            // designationTxtBox
            // 
            this.designationTxtBox.Location = new System.Drawing.Point(117, 352);
            this.designationTxtBox.Name = "designationTxtBox";
            this.designationTxtBox.Size = new System.Drawing.Size(100, 20);
            this.designationTxtBox.TabIndex = 20;
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(117, 415);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(294, 96);
            this.descriptionTxtBox.TabIndex = 23;
            this.descriptionTxtBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 22;
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
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imagePathTxtBox
            // 
            this.imagePathTxtBox.Location = new System.Drawing.Point(388, 352);
            this.imagePathTxtBox.Name = "imagePathTxtBox";
            this.imagePathTxtBox.Size = new System.Drawing.Size(100, 20);
            this.imagePathTxtBox.TabIndex = 22;
            this.imagePathTxtBox.TextChanged += new System.EventHandler(this.imagePathTxtBox_TextChanged);
            // 
            // browseImageBtn
            // 
            this.browseImageBtn.Location = new System.Drawing.Point(283, 349);
            this.browseImageBtn.Name = "browseImageBtn";
            this.browseImageBtn.Size = new System.Drawing.Size(75, 23);
            this.browseImageBtn.TabIndex = 21;
            this.browseImageBtn.Text = "Browse";
            this.browseImageBtn.UseVisualStyleBackColor = true;
            this.browseImageBtn.Click += new System.EventHandler(this.browseImageBtn_Click);
            // 
            // submitTxt
            // 
            this.submitTxt.Location = new System.Drawing.Point(165, 545);
            this.submitTxt.Name = "submitTxt";
            this.submitTxt.Size = new System.Drawing.Size(75, 23);
            this.submitTxt.TabIndex = 24;
            this.submitTxt.Text = "Submit";
            this.submitTxt.UseVisualStyleBackColor = true;
            this.submitTxt.Click += new System.EventHandler(this.submitTxt_Click);
            // 
            // cancelTxt
            // 
            this.cancelTxt.Location = new System.Drawing.Point(309, 545);
            this.cancelTxt.Name = "cancelTxt";
            this.cancelTxt.Size = new System.Drawing.Size(75, 23);
            this.cancelTxt.TabIndex = 25;
            this.cancelTxt.Text = "Cancel";
            this.cancelTxt.UseVisualStyleBackColor = true;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(437, 388);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 26;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // registrationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 580);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.cancelTxt);
            this.Controls.Add(this.submitTxt);
            this.Controls.Add(this.browseImageBtn);
            this.Controls.Add(this.imagePathTxtBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.designationTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.joiningDateDateTimePicker);
            this.Controls.Add(this.DOBdateTimePicker);
            this.Controls.Add(this.prefixComboBox);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.middleNameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.designationLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.joiningDateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "registrationForm";
            this.Text = "registrationForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label joiningDateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox middleNameTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.ComboBox prefixComboBox;
        private System.Windows.Forms.DateTimePicker DOBdateTimePicker;
        private System.Windows.Forms.DateTimePicker joiningDateDateTimePicker;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox designationTxtBox;
        private System.Windows.Forms.RichTextBox descriptionTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataOperationPageToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox imagePathTxtBox;
        private System.Windows.Forms.Button browseImageBtn;
        private System.Windows.Forms.Button submitTxt;
        private System.Windows.Forms.Button cancelTxt;
        private System.Windows.Forms.Button upload;
    }
}