using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRHelperTool.Engine.Interface;
using HRHelperToolExcelEngine;
using HRHelperToolStorageSelector;
using EventController;
using MailHandlers;
using System.Configuration;
using HRToolHelper.EmployeeLibrary;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace HRUserInterface
{
    public partial class registrationForm : Form
    {
        ComboBox item = new ComboBox();
     
        public registrationForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
           // prefixComboBox.SelectedItem = "select";
        }

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
        string imgName = "Koala.jpg";
        private void upload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = ConfigurationSettings.AppSettings["defaultUpload"].ToString();
            string strfilename = nameTxtBox.Text.Trim() + lastNameTxtBox.Text.Trim()+DOBdateTimePicker.Value.Date.ToString();
            sfd.Filter = "image files|*.jpg";
            sfd.FileName = strfilename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Image.Save(sfd.FileName);
            }

            //imagePathTxtBox.Text = strfilename;
            string path = strfilename;
            string index = Convert.ToString(path.LastIndexOf("\\"));
            int index1 = Convert.ToInt32(index);
            int index2 = path.Length;
            imgName = path.Substring(index1 + 1, index2 - index1 - 1);
        }

        private void imagePathTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitTxt_Click(object sender, EventArgs e)
         {

             bool flag = true;

             Regex rx_name = new Regex("^[a-zA-Z ]+$");
             Regex rx_ename = new Regex("([A-Za-z0-9])+@([A-Za-z0-9]{3,15})+.([A-Za-z]{2,4})$");

             if (!rx_name.IsMatch(nameTxtBox.Text))
             {
                 errNameLabel.Text = "name must be entererd";
                 flag = false;
             }
             else
             {
                 errNameLabel.Text = "";
                 flag = true;
             }


             if (!rx_name.IsMatch(middleNameTxtBox.Text))
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

            if(!rx_ename.IsMatch(emailTxtBox.Text))
            {
                errEmailLabel.Text ="enter email";
                flag = false;
            }
            else
            {
                errEmailLabel.Text = "";
                flag = true;
            }

            if(!rx_name.IsMatch(designationTxtBox.Text))
            {
                errDesignationLabel.Text ="enter designation";
                flag = false;
            }
            else
            {
                errDesignationLabel.Text = "";
                flag = true;
            }

            if(!rx_name.IsMatch(descriptionTxtBox.Text))
            {
                errDescriptionLabel.Text = "enter hobbies";
                flag = false;
            }
            else
            {
                errDescriptionLabel.Text = "";
                flag = true;
            }



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
            else if (femaleRadioButton.Checked)

                value = femaleRadioButton.Text;
            string empgender = value;
            string emailid = emailTxtBox.Text.Trim();
            string designation = designationTxtBox.Text.Trim();
            string empimagepath = imgName;
            string description = descriptionTxtBox.Text;
            Int32 teamId = (Int32)teamIdComboBox.SelectedValue;
            addempObj.AddEmployee(empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath,description,teamId);
            MessageBox.Show("employee added successfully");

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nameTxtBox_Validating(object sender, CancelEventArgs e)
        {
          


        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void prefixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
          string pathconn = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;

            SqlDataReader dataReader;
            SqlConnection con = new SqlConnection(pathconn);
            try
            {
                con.Open();

                teamIdComboBox.Items.Clear();
                SqlCommand cmd = new SqlCommand("select *from TeamList", con);
                dataReader = cmd.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(dataReader);
               // teamIdComboBox.DataSource = dataReader;
                teamIdComboBox.DisplayMember = "TeamName";
                teamIdComboBox.ValueMember = "TeamId";
                teamIdComboBox.DataSource = DT;
               
                dataReader.Close();
            }
            catch (Exception ex)
            { }
            

        }

        private void cancelTxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm welcome = new welcomeForm();
            welcome.Show();
        }
    }
}
