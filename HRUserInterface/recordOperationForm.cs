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

using HRHelperTool.Engine.Interface;
using HRHelperToolExcelEngine;
using HRHelperToolStorageSelector;
using EventController;
using MailHandlers;
using System.Configuration;
using HRToolHelper.EmployeeLibrary;
using System.Data;
using System.Text.RegularExpressions;
using HRHelperToolSQLDataAccessEngine;

namespace HRUserInterface
{
    public partial class recordOperationForm : Form
    {
        int _gridCellIndex;
        List<Employees> allEmpDataTable;
        public recordOperationForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            DOBTimePicker.Value = DateTime.Now.Date.AddYears(-35);
            showRecordBtn_Click(null,null);
            searchSelectComboBox.SelectedIndex = 0;
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

        private async void showRecordBtn_Click(object sender, EventArgs e)
        {
            StorageSelector storage = new StorageSelector();
            allEmpDataTable = await Task.FromResult<List<Employees>>(storage.getAllEmpDataTable());
            //allEmpDataTable = storage.getAllEmpDataTable();
            recordShowDataGridView.DataSource = allEmpDataTable;
            
        }

        private void recordShowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _gridCellIndex = recordShowDataGridView.SelectedCells[0].RowIndex;
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //int empid=_gridCellIndex+1;
            //string name = recordShowDataGridView[1, _gridCellIndex].Value.ToString();
            //string middlename = recordShowDataGridView[2, _gridCellIndex].Value.ToString();
            //string lastname = recordShowDataGridView[3, _gridCellIndex].Value.ToString();
        }

        private void recordOperationForm_Load(object sender, EventArgs e)
        {

        }

        private void searchSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (searchSelectComboBox.Text == "First Name")
            {
                DOJTimePicker.Visible = false;
                DOBTimePicker.Visible = false;
                searchTextbox.Visible = true;
                EnterKeywordLbl.Visible = true;
                searchBtn.Visible = false;
            }
            if (searchSelectComboBox.Text == "Employee ID")
            {
                //txtbx
                DOJTimePicker.Visible = false;
                DOBTimePicker.Visible = false;
                searchTextbox.Visible = true;
                EnterKeywordLbl.Visible = true;
                searchBtn.Visible = false;
            }
            if (searchSelectComboBox.Text == "By Team")
            {
                //txtbx
                DOJTimePicker.Visible = false;
                DOBTimePicker.Visible = false;
                searchTextbox.Visible = true;
                EnterKeywordLbl.Visible = true;
                searchBtn.Visible = false;
            }
            if (searchSelectComboBox.Text == "Email Id")
            {
                //txtbx
                DOJTimePicker.Visible = false;
                DOBTimePicker.Visible = false;
                searchTextbox.Visible = true;
                EnterKeywordLbl.Visible = true;
                searchBtn.Visible = false;
            }
            if (searchSelectComboBox.Text == "DOB")
            {
                DOJTimePicker.Visible = false;
                searchTextbox.Visible = false;
                EnterKeywordLbl.Visible = false;
                DOBTimePicker.Visible = true;
                searchBtn.Visible = true;
            }
            if (searchSelectComboBox.Text == "Date Of Joining")
            {
                DOBTimePicker.Visible = false;
                searchTextbox.Visible = false;
                EnterKeywordLbl.Visible = false;
                DOJTimePicker.Visible = true;
                searchBtn.Visible = true;
            }
            if (searchSelectComboBox.Text == "Designation")
            {
                //txtbx
                DOJTimePicker.Visible = false;
                DOBTimePicker.Visible = false;
                searchTextbox.Visible = true;
                searchBtn.Visible = false;
                EnterKeywordLbl.Visible = true;
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            Regex rx_stringFields = new Regex("^[a-zA-Z0-9]+$");
            if (rx_stringFields.IsMatch(searchTextbox.Text.Trim()))
            
            {

                if (searchSelectComboBox.Text == "First Name")
                {
                    var list = (from ab in allEmpDataTable
                               where ab.EmpName.Contains(searchTextbox.Text)
                               select ab).ToList();
                    recordShowDataGridView.DataSource = list;
                }
                if (searchSelectComboBox.Text == "Employee ID")
                {
                    Regex rx_name = new Regex("^[0-9 ]+$");
                    if (rx_name.IsMatch(searchTextbox.Text))
                    {
                        var list = (from ab in allEmpDataTable
                                   where ab.EmpID == Convert.ToInt32(searchTextbox.Text.Trim())
                                    select ab).ToList();
                        recordShowDataGridView.DataSource = list;
                    }
                }
                if (searchSelectComboBox.Text == "By Team")
                {
                    recordShowDataGridView.DataSource = allEmpDataTable;
                }
                if (searchSelectComboBox.Text == "Email Id")
                {
                    var list = (from ab in allEmpDataTable
                               where ab.EmailId.Contains(searchTextbox.Text)
                                select ab).ToList();
                    recordShowDataGridView.DataSource = list;
                }
                if (searchSelectComboBox.Text == "Designation")
                {
                    var list = (from ab in allEmpDataTable
                               where ab.Designation.Contains(searchTextbox.Text)
                                select ab).ToList();
                    recordShowDataGridView.DataSource = list;
                   
                }
                
            }
            else

                recordShowDataGridView.DataSource = allEmpDataTable;
        }
        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchSelectComboBox.Text == "DOB")
            {
                var list = (from ab in allEmpDataTable
                           where ab.DateOfBirth == DOBTimePicker.Value.Date
                            select ab).ToList();
                recordShowDataGridView.DataSource = list;
            }

            if (searchSelectComboBox.Text == "Date Of Joining")
            {
                var list = (from ab in allEmpDataTable
                           where ab.DateOfJoining == DOJTimePicker.Value.Date
                            select ab).ToList();
                recordShowDataGridView.DataSource = list;
            }
        }
    }
}
