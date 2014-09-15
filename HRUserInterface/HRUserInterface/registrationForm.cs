using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRHelperToolEngine;
namespace HRUserInterface
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void welcomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm welcomeObj = new welcomeForm();
            welcomeObj.Show();
        }

        private void browseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string strfilename = "";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strfilename = ofd.FileName;
            }
            imagePathTxtBox.Text = strfilename;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationObj = new registrationForm();
            registrationObj.Show();
        }

        private void dataOperationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            recordOperationForm recordObj = new recordOperationForm();
            recordObj.Show();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            
        }

        private void imagePathTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitTxt_Click(object sender, EventArgs e)
        {
            StorageSelector addempObj = new StorageSelector();
            string empname = nameTxtBox.Text.Trim();
            string emplastname = lastNameTxtBox.Text.Trim();
            string empmiddlename = middleNameTxtBox.Text.Trim();
            string empprifix = prefixComboBox.SelectedItem.ToString();
            DateTime dateofbirth = Convert.ToDateTime(DOBdateTimePicker.Text).Date;
            DateTime dateofjoining = Convert.ToDateTime(joiningDateDateTimePicker.Text).Date;
            string value = "";
            if (maleRadioButton.Checked)
                value = maleRadioButton.Text;
            else if(femaleRadioButton.Checked)

                value = femaleRadioButton.Text;
            string empgender = value;
            string emailid = emailTxtBox.Text.Trim();
            string designation = designationTxtBox.Text.Trim();
            string empimagepath = "none";
            addempObj.AddEmployee(empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath);
            MessageBox.Show("employee added successfully");
        }
    }
}
