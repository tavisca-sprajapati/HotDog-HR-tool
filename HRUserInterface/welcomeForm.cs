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
using EventNotificationTool;
using HRToolHelper.EmployeeLibrary;
using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace HRUserInterface
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            generateNotification(DateTime.Now.Date,5);
        }

        private async void generateNotification(DateTime date,int noofdays)
        {
            List<EventNotifier> list;
            EventNotificationToolEngine events_var = new EventNotificationToolEngine();

            list = await Task.FromResult<List<EventNotifier>>(events_var.getAllNotifications(date, noofdays));   
            
            
            string[] notificationlist=new string[list.Count];

            string name;
            string eventtype;
            string emailid;
            int day;
            string lastname;
            string notificationString;
            int i=0;
            foreach (EventNotifier notifier in list)
            {
                name = notifier.Name;
                eventtype = notifier.EventType;
                emailid = notifier.EmailId;
                day = notifier.NoOfDays;
                lastname = notifier.LastName;
                notificationString = name + " " + lastname;
                if (eventtype == "BirthDay")
                    notificationString += "'s BirthDay is";
                else
                    notificationString += " is completing "+eventtype;
                if (day > 0)
                    notificationString += " after " + day + " day.. Contact: " + emailid;
                else
                    notificationString += " today.. Contact: "+emailid;

                notificationlist[i++] = notificationString;
            }

            notificationlistBox.DataSource = notificationlist;
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
            generateNotification(DateTime.Now.Date, 5);
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

        private void notificationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string days="";
            days=notificationDaysTextBox.Text;
            Regex rx_name = new Regex("^[0-9 ]+$");
            if (rx_name.IsMatch(days) && days != "" && Convert.ToInt16(days)<10000)
            {
                generateNotification(notificationdatePicker.Value.Date,Convert.ToInt16(days));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
