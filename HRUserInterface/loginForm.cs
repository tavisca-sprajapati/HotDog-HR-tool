using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRUserInterface
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (usernameTxtBox.Text.Equals("sneha") && passwordTxtBox.Text.Equals("tope"))
            {
                this.Hide();
                welcomeForm welcomeObj = new welcomeForm();
                welcomeObj.Show();
            }
            else 
            {
                MessageBox.Show("Username and Password does not match");
            }

        }

        private void headingLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
