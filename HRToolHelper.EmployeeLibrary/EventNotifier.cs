using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRToolHelper.EmployeeLibrary
{
    public class EventNotifier
    {
        Int32 _noOfDays;
        String _eventType;
        String _name;
        String _lastName;
        String _emailId;
        public EventNotifier(Int32 numberofdays, String eventtype, String empname, String emplastname, String emailid)
        {
            _noOfDays = numberofdays;
            _eventType = eventtype;
            _name = empname;
            _lastName = emplastname;
            _emailId = emailid;

        }
        public int NoOfDays
        {
            get
            {
                return _noOfDays;
            }
        }

        public String EventType
        {
            get { return _eventType; }

        }
        public String Name
        {
            get { return _name; }
        }
        public String LastName
        {
            get { return _lastName; }
        }
        public String EmailId
        {
            get { return _emailId; }
        }

    }
}
