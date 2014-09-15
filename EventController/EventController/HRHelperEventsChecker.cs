using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRToolHelper.EmployeeLibrary;
using HRHelperToolStorageSelector;
using MailHandlers;
using HRHelperToolExcelEngine;
using HRHelperTool.Engine.Interface;

namespace EventController
{
   public class HRHelperEventsChecker
    {
        static String _imagePath = "C:/Users/sprajapati/Documents/Visual Studio 2012/Projects/";
        static String _ccList = "";

        Template temp = new Template();
        List<Employees> empList;

        StorageSelector sel = new StorageSelector();
        MailingClass mClass = new MailingClass();
       
       
        public void GetAllEployees()
        {
            empList = sel.GetAllEmployees();
        }

        public void getFifteendayRecord(int day)
        {
            List<Employees> fifteenDayRecord = new List<Employees>();
            fifteenDayRecord = sel.getFifteenDaysBdyRecords(day);
            string birthDayPerson = "apandit@tavisca.com";
            _imagePath = "C:/Users/sprajapati/Documents/Visual Studio 2012/Projects/Koala.jpg";

            string template =temp.nextFifteenDayBDYRecordsTemplate(fifteenDayRecord);

            if (fifteenDayRecord.Count > 0)
            {
                mClass.SendToAdmin("apandit@tavisca.com", birthDayPerson, template, "Birthday List", "Test HTML Email");
            }
           

        }
        public void CheckBdayEvents()
        {
            List<Employees> birthDayList;
            birthDayList = sel.TodaysBirthday();

            foreach (var x in birthDayList)
            {
                string birthDayPerson = x.EmailId;
                _ccList = "";
                _imagePath = "C:/Users/sprajapati/Documents/Visual Studio 2012/Projects/";
                _imagePath += x.EmpImagePath;
                if (birthDayPerson != null)
                {
                    mClass.SendMail("apandit@tavisca.com", birthDayPerson, temp.templateBirthBody(), "Scoutfoto", "Test HTML Email", _imagePath, "smtp.gmail.com", 587);

                    foreach (var y in empList)
                    {
                        if (birthDayPerson != y.EmailId)
                        {
                            _ccList += y.EmailId + ",";

                        }
                    }

                    _ccList = _ccList.Remove(_ccList.Length - 1);
                    Console.WriteLine("hello");


                    if (_ccList != "")
                    {
                        mClass.SendMail("apandit@tavisca.com", _ccList, temp.templateBirthBody(), "Scoutfoto", "Test HTML Email", _imagePath, "smtp.gmail.com", 587);

                    }
                }

            }
        }


        public void CheckThreeYrsCompletionEvent()
        {
            ExpierienceYearsEventChecker(3);
        }
        public void CheckFiveYrsCompletionEvent()
        {
            ExpierienceYearsEventChecker(5);
        }

        private void ExpierienceYearsEventChecker(int years)
        {
            List<Employees> YearExpList;
            YearExpList = sel.GetEmployeesWithExpierience(years);
            string templateString = "";
            if (years == 3)
            {
               templateString = temp.templateThreeBody();
            }
            else if (years == 5)
            {
                templateString = temp.templateFiveBody();
            }

            foreach (var x in YearExpList)
            {
                _ccList = "";
                string ExpPerson = x.EmailId;
                _imagePath = "C:/Users/sprajapati/Documents/Visual Studio 2012/Projects/";
                _imagePath += x.EmpImagePath;
                if (ExpPerson != null)
                {
                    mClass.SendMail("apandit@tavisca.com", ExpPerson, templateString, "Congratulations", "Test HTML Email", _imagePath, "smtp.gmail.com", 587);

                    foreach (var y in empList)
                    {
                        if (ExpPerson != y.EmailId)
                        {
                            _ccList += y.EmailId + ",";

                        }


                    }

                    _ccList = _ccList.Remove(_ccList.Length - 1);

                    if (_ccList != "")
                    {
                        mClass.SendMail("apandit@tavisca.com", _ccList, templateString, "Congratuaions to our Coleague", "Test HTML Email", _imagePath, "smtp.gmail.com", 587);

                    }
                }

            }
        }
    }
}
