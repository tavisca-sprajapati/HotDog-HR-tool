using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EventController;
namespace HRHelperTool.EvenetChecker.Invoker
{
    class Program
    {
        static void Main(string[] args)
        {
            HRHelperEventsChecker checker = new HRHelperEventsChecker();

            checker.GetAllEployees();

           // checker.CheckBdayEvents();

           // checker.CheckThreeYrsCompletionEvent();

            //checker.CheckFiveYrsCompletionEvent();

            if (DateTime.Now.Date.Day == 1 || DateTime.Now.Date.Day == 15)
                checker.getFifteendayRecord(DateTime.Now.Date.Day);
        }
    }
}
