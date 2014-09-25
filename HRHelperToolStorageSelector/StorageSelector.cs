using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using HRHelperTool.Engine.Interface;
using HRHelperToolExcelEngine;
using HRToolHelper.EmployeeLibrary;
using System.Configuration;
using System.Reflection;
using System.Data;
using HRHelperToolSQLDataAccessEngine;
namespace HRHelperToolStorageSelector
{
    public class StorageSelector
    {
        IHRHelperToolEngine selected;
        public StorageSelector()
        {
            string classNameStr = (string)ConfigurationSettings.AppSettings["selectedStorageSQL"];
            Type concreteType = Type.GetType(classNameStr);
            //no-args costructor
            this.selected = (IHRHelperToolEngine)Activator.CreateInstance(concreteType);
        }
        //Interface for storage handles classes

        //to select particular storage class


        public StorageSelector(IHRHelperToolEngine selectedStorage)
        {
            this.selected = selectedStorage;
        }
        public List<Employees> getAllEmpDataTable()
        {
            return selected.getAllEmpDataTable();
            //call it only within getAllEmployee() method of excelEngine
        }
        //gives list of all employees 
        public List<Employees> GetAllEmployees()
        {
            return selected.GetAllEmployees();
        }

        public List<Employees> getFifteenDaysBdyRecords(int day)
        {
            return selected.getFifteenDayIntervalBdys(day);

        }
        //list of people having birthday on the current day
        public List<Employees> TodaysBirthday(DateTime birthdayDate)
        {
            return selected.GetTodaysBirthdays(birthdayDate);
        }


        //list of people who completes 3 or 5 yrs
        public List<Employees> GetEmployeesWithExpierience(int years, DateTime expierienceDate)
        {
            return selected.getEmpYrsCompleted(years, expierienceDate);
        }

        //new employee adding 
        public void AddEmployee(string empname, string emplastname, DateTime dateofbirth, DateTime dateofjoining, string emailid, string designation, string empgender, string empprifix, string empmiddlename, string empimagepath,string description,Int32 teamId)
        {
            selected.AddEmployee(new Employees(empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath,description,teamId));
        }


        //update particular employees data
        public void UpdateEmployeeDetails(Int32 empid, string empname, string emplastname, DateTime dateofbirth, DateTime dateofjoining, string emailid, string designation, string empgender, string empprifix, string empmiddlename, string empimagepath)
        {
            selected.UpdateEmployeeDetails(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));
        }

        //delete particular employees record
        public void DeleteEmployeeDetails(Int32 empid)
        {
            selected.DeleteEmployeeDetails(empid);
        }
    }
}
