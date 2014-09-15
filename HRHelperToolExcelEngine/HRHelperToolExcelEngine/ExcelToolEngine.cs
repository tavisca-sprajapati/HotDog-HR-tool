using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using HRToolHelper.EmployeeLibrary;
using HRHelperTool.Engine.Interface;
namespace HRHelperToolExcelEngine
{
    public class ExcelToolEngine : IHRHelperToolEngine
    {
        Int32 empid;
        string empname;
        string emplastname;
        DateTime dateofbirth;
        DateTime dateofjoining;
        string designation;
        string empgender;
        string empprifix;
        string empimagepath;
        string emailid;
        string empmiddlename;
        DateTime todayDate = DateTime.Now.Date;
        public ExcelToolEngine()
        {
            //no-args costructor
        }

        string pathconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/sprajapati/Documents/Visual Studio 2012/Projects/employeeRecord.xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
        OleDbConnection makeConnection;
        OleDbDataAdapter myadapter;


       public List<Employees> getFifteenDayIntervalBdys(int day)
        {
            List<Employees> allFifteenDayIntervalList = new List<Employees>();
            DataSet recDS;
            DataTable fifteenDaybdyTable;
            string strDate = todayDate.ToString("MM");

            try
            {
                makeConnection = new OleDbConnection(pathconn);
                recDS = new DataSet();
                myadapter = new OleDbDataAdapter("select * from [Sheet1$] where Format(dateofbirth,'mm') in (" + strDate + ") and IsDeleted='no'", makeConnection);
                myadapter.Fill(recDS,"emp");
                fifteenDaybdyTable = recDS.Tables["emp"];
                
                foreach (DataRow row in fifteenDaybdyTable.Rows)
                {
                    empid = Convert.ToInt32(row["empid"]);
                    empname = Convert.ToString(row["empname"]);
                    emplastname = Convert.ToString(row["emplastname"]);
                    dateofbirth = Convert.ToDateTime(row["dateofbirth"]);
                    dateofjoining = Convert.ToDateTime(row["dateofjoining"]);
                    designation = Convert.ToString(row["designation"]);
                    empgender = Convert.ToString(row["empgender"]);
                    empprifix = Convert.ToString(row["empprifix"]);
                    empimagepath = Convert.ToString(row["empimagepath"]);
                    emailid = Convert.ToString(row["emailid"]);
                    empmiddlename = Convert.ToString(row["empmiddlename"]);

                    if (day == 1)
                    {
                        if (dateofbirth.Day > day && dateofbirth.Day < 16)

                            allFifteenDayIntervalList.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));
                    }
                    if (day == 15)
                    {
                        if(dateofbirth.Day > day)
                            allFifteenDayIntervalList.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));

                    }
                  }
            }
            catch (Exception ex)
            {
 
            }
            return allFifteenDayIntervalList;
        }

        public List<Employees> GetAllEmployees()
        {
            List<Employees> giveAllEmployees = new List<Employees>();
            DataSet recDS;
            DataTable allEmpDatatable;
            recDS = new DataSet();
            makeConnection = new OleDbConnection(pathconn);

            try
            {
                myadapter = new OleDbDataAdapter("select * from [Sheet1$] where and  IsDeleted='no'", makeConnection);

                myadapter.Fill(recDS, "emp");
                allEmpDatatable = recDS.Tables["emp"];

                foreach (DataRow row in allEmpDatatable.Rows)
                {
                    empid = Convert.ToInt32(row["empid"]);
                    empname = Convert.ToString(row["empname"]);
                    emplastname = Convert.ToString(row["emplastname"]);
                    dateofbirth = Convert.ToDateTime(row["dateofbirth"]);
                    dateofjoining = Convert.ToDateTime(row["dateofjoining"]);
                    designation = Convert.ToString(row["designation"]);
                    empgender = Convert.ToString(row["empgender"]);
                    empprifix = Convert.ToString(row["empprifix"]);
                    empimagepath = Convert.ToString(row["empimagepath"]);
                    emailid = Convert.ToString(row["emailid"]);
                    empmiddlename = Convert.ToString(row["empmiddlename"]);

                    giveAllEmployees.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));
                }
            }
            catch (Exception ex)
            {

            }

            return giveAllEmployees;

        }

        public List<Employees> GetTodaysBirthdays()
        {
            List<Employees> bdayList = new List<Employees>();
            string strToday = todayDate.ToString("ddMM");
            try
            {
                if (todayDate.DayOfWeek.ToString() == "Sunday" || todayDate.DayOfWeek.ToString() != "Saterday")
                {
                    DataSet recDS = new DataSet();
                    DataTable bdyDataTable = new DataTable();
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    if (todayDate.DayOfWeek.ToString() == "Friday")
                    {
                        strToday = "'" + strToday + "','" + todayDate.AddDays(1).ToString("ddMM") + "','" + todayDate.AddDays(2).ToString("ddMM") + "'";
                    }
                    myadapter = new OleDbDataAdapter("select * from [Sheet1$] where Format(dateofbirth,'ddmm') in (" + strToday + ") and IsDeleted='no'", conn);

                    myadapter.Fill(recDS, "bdayEmp");
                    bdyDataTable = recDS.Tables["bdayEmp"];

                    foreach (DataRow row in bdyDataTable.Rows)
                    {
                        empid = Convert.ToInt32(row["empid"]);
                        empname = Convert.ToString(row["empname"]);
                        emplastname = Convert.ToString(row["emplastname"]);
                        dateofbirth = Convert.ToDateTime(row["dateofbirth"]);
                        dateofjoining = Convert.ToDateTime(row["dateofjoining"]);
                        designation = Convert.ToString(row["designation"]);
                        empgender = Convert.ToString(row["empgender"]);
                        empprifix = Convert.ToString(row["empprifix"]);
                        empimagepath = Convert.ToString(row["empimagepath"]);
                        emailid = Convert.ToString(row["emailid"]);
                        empmiddlename = Convert.ToString(row["empmiddlename"]);

                        bdayList.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return bdayList;

        }

        public void AddEmployee(Employees newEmployee)
        {

            Int32 empid = 0;
            OleDbConnection con = new OleDbConnection(pathconn);

            try
            {
                con.Open();
                OleDbCommand cm2 = new OleDbCommand("select MAX(empid) from [Sheet1$]", con);
                empid = Convert.ToInt32(cm2.ExecuteScalar()) + 1;
            }
            catch (Exception ex)
            {

            }


            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into [Sheet1$] (empid,empname,empmiddlename, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix,  empimagepath,IsDeleted) values(?,?,?,?,?,?,?,?,?,?,?,?)", con);
                string date = DateTime.Now.ToString();
                cmd.Parameters.Add("empid", OleDbType.Integer).Value = empid;
                cmd.Parameters.Add("empname", OleDbType.VarChar).Value = newEmployee.EmpName;
                cmd.Parameters.Add("empmiddlename", OleDbType.VarChar).Value = newEmployee.EmpMiddleName;
                cmd.Parameters.Add("emplastname", OleDbType.VarChar).Value = newEmployee.EmpLastName;
                cmd.Parameters.Add("dateofbirth", OleDbType.Date).Value = newEmployee.DateOfBirth.Date;
                cmd.Parameters.Add("dateofjoining", OleDbType.Date).Value = newEmployee.DateOfJoining.Date;
                cmd.Parameters.Add("emailid", OleDbType.VarChar).Value = newEmployee.EmailId;
                cmd.Parameters.Add("designation", OleDbType.VarChar).Value = newEmployee.Designation;
                cmd.Parameters.Add("empgender", OleDbType.VarChar).Value = newEmployee.EmpGender;
                cmd.Parameters.Add("empprifix", OleDbType.VarChar).Value = newEmployee.EmpPrefix;

                cmd.Parameters.Add("empimagepath", OleDbType.VarChar).Value = newEmployee.EmpImagePath;
                cmd.Parameters.Add("IsDeleted", OleDbType.VarChar).Value = "no";

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public void UpdateEmployeeDetails(Employees updateEmployee)
        {
            OleDbConnection con = new OleDbConnection(pathconn);
            try
            {

                con.Open();

                OleDbCommand cmd = new OleDbCommand("update [Sheet1$] set empname=?, emplastname=?, dateofbirth=?, dateofjoining=?, emailid=?, designation=?, empgender=?, empprifix=?, empmiddlename=?, empimagepath=? where empid=" + updateEmployee.EmpID + "", con);
                string date = DateTime.Now.ToString();
                // cmd.Parameters.Add("empid", OleDbType.Integer).Value = updateEmployee.EmpID;
                cmd.Parameters.Add("empname", OleDbType.VarChar).Value = updateEmployee.EmpName;
                cmd.Parameters.Add("emplastname", OleDbType.VarChar).Value = updateEmployee.EmpLastName;
                cmd.Parameters.Add("dateofbirth", OleDbType.Date).Value = updateEmployee.DateOfBirth;
                cmd.Parameters.Add("dateofjoining", OleDbType.Date).Value = updateEmployee.DateOfJoining;
                cmd.Parameters.Add("emailid", OleDbType.VarChar).Value = updateEmployee.EmpID;
                cmd.Parameters.Add("designation", OleDbType.VarChar).Value = updateEmployee.Designation;
                cmd.Parameters.Add("empgender", OleDbType.VarChar).Value = updateEmployee.EmpGender;
                cmd.Parameters.Add("empprifix", OleDbType.VarChar).Value = updateEmployee.EmpPrefix;
                cmd.Parameters.Add("empmiddlename", OleDbType.VarChar).Value = updateEmployee.EmpMiddleName;
                cmd.Parameters.Add("empimagepath", OleDbType.VarChar).Value = updateEmployee.EmpImagePath;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public void DeleteEmployeeDetails(int empid)
        {
            throw new NotImplementedException();
        }


        public List<Employees> getEmpYrsCompleted(int years)
        {
            DateTime today = todayDate.AddYears(-years);
            string strToday = today.ToString("ddMMyyyy");
            List<Employees> threeYearsEmpList = new List<Employees>();

            try
            {
                if (today.DayOfWeek.ToString() == "Sunday" || today.DayOfWeek.ToString() != "Saturday")
                {
                    // MessageBox.Show("holyday");

                    DataSet empWithThreeDS = new DataSet();
                    DataTable empThreeYrDT;
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    if (todayDate.DayOfWeek.ToString() != "Monday")
                    {
                        strToday = "'" + strToday + "','" + today.AddDays(-1).ToString("ddMMyyyy") + "','" + today.AddDays(-2).ToString("ddMMyyyy") + "'";
                    }

                    myadapter = new OleDbDataAdapter("select * from [Sheet1$] where Format(dateofjoining,'ddmmyyyy') in (" + strToday + ")", conn);

                    myadapter.Fill(empWithThreeDS, "emp");
                    empThreeYrDT = empWithThreeDS.Tables["emp"];

                    foreach (DataRow row in empThreeYrDT.Rows)
                    {
                        empid = Convert.ToInt32(row["empid"]);
                        empname = Convert.ToString(row["empname"]);
                        emplastname = Convert.ToString(row["emplastname"]);
                        dateofbirth = Convert.ToDateTime(row["dateofbirth"]);
                        dateofjoining = Convert.ToDateTime(row["dateofjoining"]);
                        designation = Convert.ToString(row["designation"]);
                        empgender = Convert.ToString(row["empgender"]);
                        empprifix = Convert.ToString(row["empprifix"]);
                        empimagepath = Convert.ToString(row["empimagepath"]);
                        emailid = Convert.ToString(row["emailid"]);
                        empmiddlename = Convert.ToString(row["empmiddlename"]);

                        threeYearsEmpList.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return threeYearsEmpList;
        }
    }
}
