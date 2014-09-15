using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRToolHelper.EmployeeLibrary;
namespace HRHelperTool.Engine.Interface
{
    public interface IHRHelperToolEngine
    {
        List<Employees> GetAllEmployees();
        List<Employees> GetTodaysBirthdays();
        void AddEmployee(Employees newEmployee);
        void UpdateEmployeeDetails(Employees updateEmployee);
        void DeleteEmployeeDetails(Int32 empid);

        List<Employees> getEmpYrsCompleted(int years);

        List<Employees> getFifteenDayIntervalBdys(int day);
    }
}
