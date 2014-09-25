using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Configuration;
using HRToolHelper.EmployeeLibrary;

namespace EventTemplates
{
   public  class Template
    {
        public string templateBirthBodyToOthers(string name, string gender)
        {
            try
            {
                string birthDayToOthers = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"].ToString() + "BirthdayToOthersTemplate.html");
                if (gender == "Male")
                    return string.Format(birthDayToOthers, name, "him");
                else
                    return string.Format(birthDayToOthers, name, "her");
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "----" + DateTime.Now);
                }
                return "Many Many Happy Returns Of the day to" + name + "!!!!";
            }

        }




        public string templateBirthBody(string name,string gender)
        {
            try
            {
                string gendertemplate="hisBirthdayTemplate.html";
                if(gender=="Female")
                    gendertemplate = "herBirthdayTemplate.html";
                string birthDay = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"] + gendertemplate);

                return string.Format(birthDay, name);
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "----" + DateTime.Now);
                }
                return "Dear" + name + "many many happy returns of the day!!";
            }
        }

        public string nextFifteenDayBDYRecordsTemplate(List<Employees> list)
        {
            string template = "";
            template += "<html><body><table border=1>";
            template += "<th>Employee Id</th><th>Name</th><th>Date of Birthday</th><th>Email ID</th><th>Designation</th>";
            foreach (var x in list)
            {
                template += "<tr>";
                template += "<td>" + x.EmpID + "</td>" + x.EmpName + " " + x.EmpLastName + "<td>" + x.DateOfBirth.Date.ToString("dd/MM/yyyy") + "</td>";
                template += "<td>" + x.EmailId + "</td><td>" + x.Designation + "</td>";
                template += "<tr>";
            }
            template += "</body></table></html>";
            return template;
        }

        public string templateThreeBody(string name)
        {
            try
            {
                string threeyear = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"].ToString() + "ThreeYearsTemplate.html");
                return string.Format(threeyear, name);
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "----" + DateTime.Now);
                }
                return "Congratulations On Completing Three Years!!!!!!";

            }
        }
        public string templateThreeYearToOthers(string name, string gender)
        {
            try
            {
                string threeyearToOthers = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"].ToString() + "ThreeYearsTemplateToOthers.html");
                if (gender == "Male")
                    return string.Format(threeyearToOthers, name, "him");
                else
                    return string.Format(threeyearToOthers, name, "her");
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "----" + DateTime.Now);
                }
                return "Congratulations On Completing Three Years to" + name + "!!!";
            }
        }





        public string templateFiveBody(string name)
        {
            try
            {
                string fiveyear = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"].ToString() + "FiveYearsTemplate.html");
                return string.Format(fiveyear, name);
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "----" + DateTime.Now);
                }
                return "Congratulations On Completing Five Years!!!!!!";
            }
        }
        public string templateFiveYearToOthers(string name, string gender)
        {
            try
            {
                string fiveyearToOthers = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"].ToString() + "FiveYearsToOthersTemplate.html");
                if (gender == "Male")
                    return string.Format(fiveyearToOthers, name, "him");
                else
                    return string.Format(fiveyearToOthers, name, "her");
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "" + DateTime.Now);
                }
                return "Congratulations On Completing Three Years!!!!!!";
            }
        }


        public string templateNewBieBody(string name)
        {
            try
            {
                string newbie = File.ReadAllText(ConfigurationSettings.AppSettings["TemplatePath"].ToString() + "NewBieTemplate.html");
                return string.Format(newbie, name);
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D/:ErrorLogForHRTool", true))
                {
                    file.WriteLine(e.StackTrace + "" + DateTime.Now);
                }
                return "Welcome to Tavisca..!!!!!!";
            }
        }
    }
}
