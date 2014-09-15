using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRToolHelper.EmployeeLibrary
{
    public  class Employees
    {
        private Int32 empID;
        private string empName;
        private string empLastName;
        private DateTime dateOfBirth;
        private DateTime dateOfJoining;
        private string emailId;
        private string empDesignation;
        private string empGender;
        private string empPrefix;
        private string empMiddleName;
        private string empImagePath;

        public Employees()
        {
        }
        public Employees(Int32 empid, string empname, string emplastname, DateTime dateofbirth, DateTime dateofjoining, string emailid, string designation, string empgender, string empprifix, string empmiddlename, string empimagepath)
        {
            this.empID = empid;
            this.empName = empname;
            this.empLastName = emplastname;
            this.dateOfBirth = dateofbirth;
            this.dateOfJoining = dateofjoining;
            this.emailId = emailid;
            this.empDesignation = designation;
            this.empGender = empgender;
            this.empPrefix = empprifix;
            this.empMiddleName = empmiddlename;
            this.empImagePath = empimagepath;
        }
        public Employees(string empname, string emplastname, DateTime dateofbirth, DateTime dateofjoining, string emailid, string designation, string empgender, string empprifix, string empmiddlename, string empimagepath)
        {

            this.empName = empname;
            this.empLastName = emplastname;
            this.dateOfBirth = dateofbirth;
            this.dateOfJoining = dateofjoining;
            this.emailId = emailid;
            this.empDesignation = designation;
            this.empGender = empgender;
            this.empPrefix = empprifix;
            this.empMiddleName = empmiddlename;
            this.empImagePath = empimagepath;
        }
        public Int32 EmpID { get { return empID; } }

        public string EmpName { get { return empName; } }

        public string EmpLastName { get { return empLastName; } }

        public DateTime DateOfBirth { get { return dateOfBirth; } }

        public DateTime DateOfJoining { get { return dateOfJoining; } }

        public string EmailId { get { return emailId; } }

        public string Designation { get { return empDesignation; } }

        public string EmpGender { get { return empGender; } }

        public string EmpPrefix { get { return empPrefix; } }

        public string EmpMiddleName { get { return empMiddleName; } }

        public string EmpImagePath { get { return empImagePath; } }
    }
}
