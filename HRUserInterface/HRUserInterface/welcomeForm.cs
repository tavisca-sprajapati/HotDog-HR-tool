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
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm recordObj = new registrationForm();
            recordObj.Show();
        }

        private void viewRecordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            recordOperationForm recordObj = new recordOperationForm();
            recordObj.Show();

        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            StorageSelector str = new StorageSelector();
            //str.AddEmployee();
        }

        private void headingLabel_Click(object sender, EventArgs e)
        {

        }

        private void notificationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void welcomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm welcomeObj = new welcomeForm();
            welcomeObj.Show();
        }

        private void registarationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationObj = new registrationForm();
            registrationObj.Show();
        }

        private void recordOperationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            recordOperationForm recordObj = new recordOperationForm();
            recordObj.Show();
        }
    }
}
