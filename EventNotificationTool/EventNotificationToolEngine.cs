using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRHelperTool.Engine.Interface;
using HRHelperToolExcelEngine;
using HRHelperToolStorageSelector;
using HRToolHelper.EmployeeLibrary;
using System.Data;

namespace EventNotificationTool
{
   public class EventNotificationToolEngine
    {
       
        public List<EventNotifier> getAllNotifications(DateTime todaysDate,int days)
        {
            StorageSelector selectmethod =new StorageSelector();
            List<Employees> allEmpDataTable = selectmethod.getAllEmpDataTable();

            DateTime bdynextdays = todaysDate.AddDays(days);
            DateTime fiveyrs = todaysDate.AddYears(-5);
            DateTime fivenextyrs = todaysDate.AddYears(-5).AddDays(days);
            DateTime threeyrs = todaysDate.AddYears(-3);
            DateTime threenextyrs = todaysDate.AddYears(-3).AddDays(days);
            List<EventNotifier> listnotification = new List<EventNotifier>();

            int total1;
            int total2;
            int total3;
            int noOfdays;
            DateTime threeyrsDate;
            foreach (Employees rows in allEmpDataTable)
            {
                total1 = rows.DateOfBirth.Day + rows.DateOfBirth.Month * 100;
                total2 = todaysDate.Day + todaysDate.Month * 100;

                total3= bdynextdays.Day + bdynextdays.Month * 100 ;

                if(total1 >= total2 && total1 <= total3)
                {
                    noOfdays = rows.DateOfBirth.DayOfYear - todaysDate.DayOfYear;
                    listnotification.Add(new EventNotifier(noOfdays, "BirthDay", rows.EmpName,rows.EmpLastName, rows.EmailId));
                }

                threeyrsDate = rows.DateOfJoining;

                if (threeyrsDate >= threeyrs && threeyrsDate <= threenextyrs)
                {
                    noOfdays = threeyrsDate.DayOfYear - todaysDate.DayOfYear;
                    listnotification.Add(new EventNotifier(noOfdays, "Three Years", rows.EmpName, rows.EmpLastName, rows.EmailId));
                }

                if (threeyrsDate >= fiveyrs && threeyrsDate <= fivenextyrs)
                {
                    noOfdays = threeyrsDate.DayOfYear - todaysDate.DayOfYear;
                    listnotification.Add(new EventNotifier(noOfdays, "Five Years", rows.EmpName, rows.EmpLastName, rows.EmailId));
                }
            }

            return listnotification;
        }
    }
}
