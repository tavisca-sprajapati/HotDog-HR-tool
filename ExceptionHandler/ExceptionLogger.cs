using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Configuration;

namespace ExceptionHandler
{
    public class ExceptionLogger
    {
        public void DoLog(Exception e)
        {
            string logStr = ConfigurationSettings.AppSettings["ErrorLogPath"].ToString();
            try
            {
                using (StreamWriter stream = new StreamWriter(logStr + "EventExceptionLogFile.txt", true))
                {
                    stream.WriteLine("---------------------------------");
                    stream.WriteLine("DateTime:" + DateTime.Now);
                    stream.WriteLine("Message:" + e.Message);
                    stream.WriteLine("StackTrace:" + e.StackTrace);
                    stream.WriteLine("---------------------------------");

                }

            }
            catch (Exception ell)
            {
                // Console.WriteLine("dffffffffd");
            }





        }
    }
}
