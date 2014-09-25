using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using EventController;

namespace HRHelperTool.EvenetChecker.Invoker
{
    class Program
    {
        static void Main(string[] args)
        {

            HRHelperEventsChecker checker = new HRHelperEventsChecker();

           // checker.GetAllEployees();

            checker.CheckBdayEvents(DateTime.Now.Date);

            //checker.CheckThreeYrsCompletionEvent(3, DateTime.Now.Date);

            //checker.CheckFiveYrsCompletionEvent(5, DateTime.Now.Date);

           // if (DateTime.Now.Date.Day == 1 || DateTime.Now.Date.Day == 15)
                checker.getFifteendayRecord(DateTime.Now.Date.Day);
        }
    }
}
