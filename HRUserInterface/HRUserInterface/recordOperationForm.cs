using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRHelperToolEngine;
namespace HRUserInterface
{
    public partial class recordOperationForm : Form
    {
        public recordOperationForm()
        {
            InitializeComponent();
        }

        private void welcomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm welcomeObj = new welcomeForm();
            welcomeObj.Show();
        }

        private void registrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registerObj = new registrationForm();
            registerObj.Show();
        }

        private void dataOperationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            recordOperationForm recordObj = new recordOperationForm();
            recordObj.Show();
        }

        private void showRecordBtn_Click(object sender, EventArgs e)
        {
            StorageSelector storage = new StorageSelector();
            List<Employees> emplist = storage.GetAllEmployees();
            recordShowDataGridView.DataSource = emplist;
        }

        private void recordShowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(PathToExcelFile);
            if (file.Exists)
            {
                Response.Clear();
                Response.ClearHeaders();
                Response.ClearContent();
                Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
                Response.AddHeader("Content-Type", "application/Excel");
                Response.ContentType = "application/vnd.xls";
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.WriteFile(file.FullName);
                Response.End();
            }
            else
            {
                Response.Write("This file does not exist.");
            }
        }
    }
}
