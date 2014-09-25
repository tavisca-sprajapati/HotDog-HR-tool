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
    public partial class updateRecordForm : Form
    {
        public updateRecordForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void decriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("done");
            Regex rx_name = new Regex("^[a-zA-Z ]+$");
            Regex rx_ename = new Regex("([A-Za-z0-9])+@([A-Za-z0-9]{3,15})+.([A-Za-z]{2,4})$");
            bool flag = true;

            if (!rx_name.IsMatch(firstNameTxtBox.Text))
            {
                errNameLabel.Text = "enter first name";
                flag = false;
            }
            else
            {
                errNameLabel.Text = "";
                flag = true;
            }

            if (!rx_name.IsMatch(MiddleNameTxtBox.Text))
            {
                errMName.Text = "enter middle name";
                flag = false;
            }
            else
            {
                errMName.Text = "";
                flag = true;
            }

            if (!rx_name.IsMatch(lastNameTxtBox.Text))
            {
                errLName.Text = "enter last name";
                flag = false;
            }
            else
            {
                errLName.Text = "";
                flag = true;
            }

            //if (!maleRadioButton.Checked || !femaleRadioButton.Checked)
            //{
            //    errGenderLabel.Text = "select gender";
            //    flag = false;
            //}
            //else
            //{
            //    errGenderLabel.Text = "";
            //    flag = true;
            //}

            if (!rx_ename.IsMatch(emailTxtBox.Text))
            {
                errEmailMessage.Text = "enter email id";
                flag = false;
            }
            else
            {
                errEmailMessage.Text = "";
                flag = true;
            }

            if (!rx_name.IsMatch(designationTxtBox.Text))
            {
                errDesignationLabel.Text = "enter designation";
                flag = false;
            }
            else
            {
                errDesignationLabel.Text = "";
                flag = true;
            }

            if (!rx_name.IsMatch(decriptionRichTextBox.Text))
            {
                errDescriptionLabel.Text = "enter your hobbies";
                flag = false;
            }
            else
            {
                errDescriptionLabel.Text = "";
                flag = true;
            }


            if (flag == false)
            {
                MessageBox.Show("fill all the fields");
            }
            else
            {
                MessageBox.Show("record updated");
            }

        }

        private void firstNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
