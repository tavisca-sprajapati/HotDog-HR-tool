using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRUserInterface
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }
        bool flag = true;

        private void welcomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm welcomeObj = new welcomeForm();
            welcomeObj.Show();
        }

        private void browseImageBtn_Click(object sender, EventArgs e)
        {


            string strfilename = "";
            OpenFileDialog ofd = new OpenFileDialog();
           

            ofd.Filter = "image files (*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|(*.JPEG)|*.JPEG|(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strfilename = ofd.FileName;
                pictureBox1.ImageLocation = ofd.FileName;

            }

            imagePathTxtBox.Text = strfilename;
            string path = imagePathTxtBox.Text;
            string index = Convert.ToString(path.LastIndexOf("\\"));
            int index1 = Convert.ToInt32(index);
            int index2 = path.Length;
            string imgName = path.Substring(index1 + 1, index2 - index1 - 1);

            //MessageBox.Show(imgName);


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
            //StorageSelector addempObj = new StorageSelector();
            //string empname = nameTxtBox.Text.Trim();
            //string emplastname = lastNameTxtBox.Text.Trim();
            //string empmiddlename = middleNameTxtBox.Text.Trim();
            //string empprifix = prefixComboBox.SelectedItem.ToString();
            //DateTime dateofbirth = Convert.ToDateTime(DOBdateTimePicker.Text).Date;
            //DateTime dateofjoining = Convert.ToDateTime(joiningDateDateTimePicker.Text).Date;
            //string value = "";
            //if (maleRadioButton.Checked)
            //    value = maleRadioButton.Text;
            //else if (femaleRadioButton.Checked)

            //    value = femaleRadioButton.Text;
            //string empgender = value;
            //string emailid = emailTxtBox.Text.Trim();
            //string designation = designationTxtBox.Text.Trim();
            //string empimagepath = "none";
            //addempObj.AddEmployee(empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath);
            //MessageBox.Show("employee added successfully");
           

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rx_name = new Regex("[a-zA-Z]{3,20}");
            if (!rx_name.IsMatch(nameTxtBox.Text))
            {
                e.Cancel = true;
                errNameLabel.Text = "Enter First name";
                

            }
            else
            {
                errNameLabel.Text = "";
                
            }
        }

        private void middleNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rx_name = new Regex("[a-zA-Z]{3,20}");
            if (!rx_name.IsMatch(middleNameTxtBox.Text))
            {
                e.Cancel = true;
                errMNameLabel.Text = "enter middle name";
               
            }
            else
            {
                errMNameLabel.Text = "";
               
            }
        }

        private void lastNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rx_name = new Regex("[a-zA-Z]{3,20}");
            if (!rx_name.IsMatch(lastNameTxtBox.Text))
            {
                e.Cancel = true;
                errLNameLabel.Text = "enter last name";
                
            }
            else
            {
                errLNameLabel.Text = "";
                

            }

        }

        private void emailTxtBox_Validating(object sender, CancelEventArgs e)
        {

            Regex rx_email = new Regex("([A-Za-z0-9])+@([A-Za-z0-9]{3,15})+.([A-Za-z]{2,4})$");
            if (!rx_email.IsMatch(emailTxtBox.Text))
            {
                e.Cancel = true;
                errEmailLabel.Text = "enter valid Email ID";
                flag = false;
            }
            else
            {
                errEmailLabel.Text = "";
                flag = true;
            }
        }

        private void designationTxtBox_Validating(object sender, CancelEventArgs e)
        {

            Regex rx_name = new Regex("[a-zA-Z]{3,20}");
            if (!rx_name.IsMatch(designationTxtBox.Text))
            {
                e.Cancel = true;
                errDestinationLabel.Text = "enter designation";
               
            }
            else
            {
                errDestinationLabel.Text = "";
                
            }

        }

        private void descriptionTxtBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rx_name = new Regex("[a-zA-Z]{3,20}");
            if (!rx_name.IsMatch(descriptionTxtBox.Text))
            {
                e.Cancel = true;
                errDescriptionLabel.Text = "please enter your hobbies";
                
            }
            else
            {
                errDescriptionLabel.Text = "";
                
            }

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:\\Users\\rsarda\\Pictures\\images";
            string strfilename = "";
            sfd.Filter = "image files|*.jpg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                strfilename = sfd.FileName;
                pictureBox1.Image.Save(sfd.FileName);
            }

            //imagePathTxtBox.Text = strfilename;
            string path = strfilename;
            string index = Convert.ToString(path.LastIndexOf("\\"));
            int index1 = Convert.ToInt32(index);
            int index2 = path.Length;
            string imgName = path.Substring(index1 + 1, index2 - index1 - 1);
        }
    }
}
