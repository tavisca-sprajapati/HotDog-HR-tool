using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRHelperTool.Engine.Interface;
using HRToolHelper.EmployeeLibrary;
using EventTemplates;
using MailHandlers;
using ExceptionHandler;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HRHelperToolSQLDataAccessEngine
{
    public class SQLDataAccessToolEngine : IHRHelperToolEngine
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
        DataTable empDataTable;
        string holydayStr = ConfigurationSettings.AppSettings["holydayList"];
        string ccLIst = ConfigurationSettings.AppSettings["CCList"];
        string fromEmailID = ConfigurationSettings.AppSettings["fromEmailID"];


       public SQLDataAccessToolEngine()
       {
 
       }

       static string pathconn = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;

       SqlConnection sqlcon;
       SqlDataAdapter sqldataAdapter;

       public List<Employees> GetAllEmployees()
       {
           throw new NotImplementedException();
       }

       public List<Employees> GetTodaysBirthdays(DateTime date)
       {
           List<Employees> bdayList = new List<Employees>();
           todayDate = date;
           string strToday = todayDate.ToString("ddMM");
           try
           {
               if (todayDate.DayOfWeek.ToString() != "Sunday" || todayDate.DayOfWeek.ToString() != "Saterday")
               {
                   SqlDataReader recDR;
                   SqlConnection sqlcon = new SqlConnection(pathconn);
                   if (todayDate.DayOfWeek.ToString() == "Friday")
                   {
                       strToday = "'" + strToday + "','" + todayDate.AddDays(1).ToString("ddMM") + "','" + todayDate.AddDays(2).ToString("ddMM") + "'";
                   }

                   sqlcon.Open();
                   SqlCommand sqlcmd = new SqlCommand("TodayBdayProcedure",sqlcon);
                   sqlcmd.CommandType = CommandType.StoredProcedure;
                  // sqlcmd.Parameters.Add("@listDate",SqlDbType.VarChar).Value = strToday;

                   recDR = sqlcmd.ExecuteReader();
                   if (recDR.HasRows)
                   {
                       while (recDR.Read())
                       {
                           empid = Convert.ToInt32(recDR.GetValue(0));
                           empname = Convert.ToString(recDR.GetString(1));
                           emplastname = Convert.ToString(recDR.GetString(3));
                           dateofbirth = Convert.ToDateTime(recDR.GetValue(4));
                           dateofjoining = Convert.ToDateTime(recDR.GetValue(5));
                           designation = Convert.ToString(recDR.GetString(10));
                           empgender = Convert.ToString(recDR.GetString(6));
                           empprifix = Convert.ToString(recDR.GetString(7));
                           empimagepath = Convert.ToString(recDR.GetString(11));
                           emailid = Convert.ToString(recDR.GetString(8));
                           empmiddlename = Convert.ToString(recDR.GetString(2));

                           bdayList.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));

                       }
                       recDR.NextResult();
                   }
                   recDR.Close();
                  
               }
           }
           catch (Exception ex)
           {
               ExceptionLogger log = new ExceptionLogger();
               log.DoLog(ex);

           }
           return bdayList;
       }

       public void AddEmployee(Employees newEmployee)
       {
           SqlConnection conAdd = new SqlConnection(pathconn);
           try
           {
               conAdd.Open();
               SqlCommand sqlAdd = new SqlCommand("InsertEmployee", conAdd);
               sqlAdd.CommandType = CommandType.StoredProcedure;
               sqlAdd.Parameters.Add("name", SqlDbType.NVarChar).Value = newEmployee.EmpName;
               sqlAdd.Parameters.Add("middlename", SqlDbType.NVarChar).Value = newEmployee.EmpMiddleName;
               sqlAdd.Parameters.Add("lastname", SqlDbType.NVarChar).Value = newEmployee.EmpLastName;
               sqlAdd.Parameters.Add("dob", SqlDbType.Date).Value = newEmployee.DateOfBirth;
               sqlAdd.Parameters.Add("doj", SqlDbType.Date).Value = newEmployee.DateOfJoining;
               sqlAdd.Parameters.Add("gender", SqlDbType.NVarChar).Value = newEmployee.EmpGender;
               sqlAdd.Parameters.Add("isPresent", SqlDbType.Bit).Value = 1;
               sqlAdd.Parameters.Add("prefix", SqlDbType.NVarChar).Value = newEmployee.EmpPrefix;
               sqlAdd.Parameters.Add("emailid", SqlDbType.NVarChar).Value = newEmployee.EmailId;
               sqlAdd.Parameters.Add("imagepath", SqlDbType.NVarChar).Value = newEmployee.EmpImagePath;
               sqlAdd.Parameters.Add("designation", SqlDbType.NVarChar).Value = newEmployee.Designation;
               sqlAdd.Parameters.Add("description", SqlDbType.NVarChar).Value = newEmployee.Description;
               sqlAdd.Parameters.Add("teamid", SqlDbType.Int).Value = newEmployee.TeamId;
               sqlAdd.ExecuteNonQuery();
           }
           catch (Exception ex)
           { 
           }
           
       }

       public void UpdateEmployeeDetails(Employees updateEmployee)
       {
           throw new NotImplementedException();
       }

       public void DeleteEmployeeDetails(int empid)
       {
           throw new NotImplementedException();
       }

       public List<Employees> getEmpYrsCompleted(int years, DateTime date)
       {
           DateTime today = todayDate.AddYears(-years);
           string strToday = today.ToString("MM/dd/yyyy");
           List<Employees> threeYearsEmpList = new List<Employees>();

           try
           {
               if (today.DayOfWeek.ToString() != "Sunday" || today.DayOfWeek.ToString() != "Saturday")
               {
                   SqlDataReader recDR;
                   SqlConnection sqlconn = new SqlConnection(pathconn);

                   SqlCommand sqlcmd= new SqlCommand("ThreeYearsCompletionProcedure", sqlconn);
                       if(years==5)
                       {
                           sqlcmd = new SqlCommand("FiveYearCompletionProcedure", sqlconn);
                       
                       }
                   sqlcmd.CommandType = CommandType.StoredProcedure;
                   sqlcmd.Parameters.Add("@years", SqlDbType.Int).Value = years;
                   sqlconn.Open();
                   recDR = sqlcmd.ExecuteReader();
                   if (recDR.HasRows)
                   {
                       while (recDR.Read())
                       {
                           empid = Convert.ToInt32(recDR.GetValue(0));
                           empname = Convert.ToString(recDR.GetString(1));
                           empmiddlename = Convert.ToString(recDR.GetString(2));
                           emplastname = Convert.ToString(recDR.GetString(3));
                           dateofbirth = Convert.ToDateTime(recDR.GetValue(4));
                           dateofjoining = Convert.ToDateTime(recDR.GetValue(5));
                           empgender = Convert.ToString(recDR.GetString(6));
                           empprifix = Convert.ToString(recDR.GetString(7));
                           emailid = Convert.ToString(recDR.GetString(8));
                           designation = Convert.ToString(recDR.GetString(10));
                           empimagepath = Convert.ToString(recDR.GetString(11));

                           threeYearsEmpList.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining, emailid, designation, empgender, empprifix, empmiddlename, empimagepath));
                       }
                       recDR.NextResult();
                   }
                   recDR.Close();

               }
           }
           catch (Exception ex)
           {
               ExceptionLogger log = new ExceptionLogger();
               log.DoLog(ex);

           }
           return threeYearsEmpList;
       }

       public List<Employees> getFifteenDayIntervalBdys(int day)
       {
           DateTime compareDate = DateTime.Now.AddDays(-10).Date;
           List<Employees> bdayList = new List<Employees>();
           SqlDataReader recDR;
           day = 15;
           //DataTable fifteenDaybdyTable;
           sqlcon = new SqlConnection(pathconn);
           try
           {
               
               string abc = "";
               SqlCommand sqlCmd = new SqlCommand("FifteenDayBdyProcedure", sqlcon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               sqlCmd.Parameters.Add("@TodaysDate", SqlDbType.Date).Value = compareDate;
               sqlCmd.Parameters.Add("@days", SqlDbType.Int).Value = day;
               sqlcon.Open();
               recDR = sqlCmd.ExecuteReader();
               if (recDR.HasRows)
               {
                   while (recDR.Read())
                   {
                       empid = Convert.ToInt32(recDR.GetValue(0));
                       empname = Convert.ToString(recDR.GetString(1));
                       emplastname = Convert.ToString(recDR.GetString(3));
                       dateofbirth = Convert.ToDateTime(recDR.GetValue(4)).Date;
                       emailid = Convert.ToString(recDR.GetString(8));
                       designation = Convert.ToString(recDR.GetString(10));
                       bdayList.Add(new Employees(empid, empname, emplastname,dateofbirth, emailid,designation));
                   }
                   recDR.NextResult();
               }
               recDR.Close();

           }
           catch (Exception ex)
           {

           }
           finally
           {
               if (sqlcon.State == ConnectionState.Open)
                   sqlcon.Close();
           }
           return bdayList;
       }

       public List<Employees> getAllEmpDataTable()
       {
           sqlcon = new SqlConnection(pathconn);
           SqlDataReader recDR;
           DataTable allEmpDataTable=new DataTable();
           List<Employees> allemp = new List<Employees>();

           try
           {
               sqlcon.Open();
               string abc = "";
               SqlCommand sqlCmd = new SqlCommand("ShowAllEmployeeDataProcedure", sqlcon);
               sqlCmd.CommandType = CommandType.StoredProcedure;
               recDR = sqlCmd.ExecuteReader();
                if (recDR.HasRows)
                {
                    while (recDR.Read())
                    {
                        empid = Convert.ToInt32(recDR.GetValue(0));
                        empname = Convert.ToString(recDR.GetString(1));
                        emplastname = Convert.ToString(recDR.GetString(3));
                        dateofbirth = Convert.ToDateTime(recDR.GetValue(4)).Date;
                        dateofjoining = Convert.ToDateTime(recDR.GetValue(5)).Date;
                        emailid=Convert.ToString(recDR.GetString(8));
                        designation=Convert.ToString(recDR.GetString(10));
                        empgender=Convert.ToString(recDR.GetString(6));
                        empprifix=Convert.ToString(recDR.GetString(7));
                        empmiddlename=Convert.ToString(recDR.GetString(2));
                        empimagepath = Convert.ToString(recDR.GetString(11));
                     
                        allemp.Add(new Employees(empid, empname, emplastname, dateofbirth, dateofjoining,emailid, designation,empgender,empprifix,empmiddlename,empimagepath));
                    }
                    recDR.NextResult();
                }
                recDR.Close();
            
           }
           catch (Exception ex)
           {

           }
           finally
           {
               if (sqlcon.State == ConnectionState.Open)
                   sqlcon.Close();
           }
           return allemp;
       }
    }
}
