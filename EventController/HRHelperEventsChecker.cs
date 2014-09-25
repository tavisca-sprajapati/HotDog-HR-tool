using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRToolHelper.EmployeeLibrary;
using HRHelperToolStorageSelector;
using MailHandlers;
//using HRHelperToolExcelEngine;
using HRHelperTool.Engine.Interface;
using System.Configuration;
using EventTemplates;

namespace EventController
{
    public class HRHelperEventsChecker
    {
        static String appConfigImagePath = (string)ConfigurationSettings.AppSettings["ImagePath"];
        String _imagePath = appConfigImagePath;
        string _bodyImagePath = appConfigImagePath;
        String _ccList = ConfigurationSettings.AppSettings["CCList"];

        Template temp = new Template();

        StorageSelector storageselector = new StorageSelector();
        MailingClass mClass = new MailingClass();


        public void getFifteendayRecord(int day)
        {
            List<Employees> fifteenDayRecord = new List<Employees>();
            fifteenDayRecord = storageselector.getFifteenDaysBdyRecords(day);
            string birthDayPerson = "apandit@tavisca.com";

            string template = temp.nextFifteenDayBDYRecordsTemplate(fifteenDayRecord);

            if (fifteenDayRecord.Count > 0)
            {
                mClass.SendToAdmin("apandit@tavisca.com", birthDayPerson, template, "Birthday List", "BirthDay List");
            }


        }
        public void CheckBdayEvents(DateTime birthdayDate)
        {
            List<Employees> birthDayList;
            birthDayList = storageselector.TodaysBirthday(birthdayDate);

            foreach (var x in birthDayList)
            {
                string birthDayPerson = x.EmailId;

                _imagePath = appConfigImagePath;
                _imagePath += x.EmpImagePath;
                _bodyImagePath = appConfigImagePath;
                if(x.EmpGender=="Male")
                _bodyImagePath += "image002.png";
                if(x.EmpGender=="Female")
                _bodyImagePath += "image004.jpg";
                if (birthDayPerson != null)
                {
                    mClass.SendMail("apandit@tavisca.com", birthDayPerson, _ccList, temp.templateBirthBody(x.EmpName,x.EmpGender), "Happy Birthday", "happy birthday", _imagePath, _bodyImagePath);

                }

            }
        }


        public void CheckThreeYrsCompletionEvent(int day, DateTime threeYrsDate)
        {
            ExpierienceYearsEventChecker(day, threeYrsDate);
        }
        public void CheckFiveYrsCompletionEvent(int day, DateTime fiveYrsDate)
        {
            ExpierienceYearsEventChecker(day, fiveYrsDate);
        }

        private void ExpierienceYearsEventChecker(int years, DateTime expierienceDate)
        {
            List<Employees> YearExpList;
            YearExpList = storageselector.GetEmployeesWithExpierience(years, expierienceDate);
            string templateString = "";
            string Subject = "";

            //string OthersTemplate = "";
            //string fiveYearsOthersTemplate = "";
            foreach (var x in YearExpList)
            {


                if (years == 3)
                {
                    templateString = temp.templateThreeBody(x.EmpName);
                    //OthersTemplate = temp.templateThreeYearToOthers(x.EmpName,x.EmpGender);
                    Subject = "Congratulations for completing three years in tavisca";
                }
                else if (years == 5)
                {
                    templateString = temp.templateFiveBody(x.EmpName);
                    //OthersTemplate=temp.templateFiveYearToOthers(x.EmpName,x.EmpGender);
                    Subject = "Congratulations for completing five years in tavisca";
                }

                string ExpPerson = x.EmailId;
                _imagePath = appConfigImagePath;
                _imagePath += x.EmpImagePath;
                _bodyImagePath = appConfigImagePath;
                _bodyImagePath += "image001.jpg";
                if (ExpPerson != null)
                {
                    mClass.SendMail("apandit@tavisca.com", ExpPerson, _ccList, templateString, "Congratulations", Subject, _imagePath, _bodyImagePath);

                }

            }
        }
    }
}
