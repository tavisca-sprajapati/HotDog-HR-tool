using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRToolHelper.EmployeeLibrary;

namespace EventController
{
   public class Template
    {
       /*
        string birthDay = @"<html>
                              <body>
                                <table width=""100%"">
                                <tr>
                                    <td style=""font-style:arial; color:maroon; font-weight:bold"" >
                                   Hi! <br>
                                    <img src=cid:myImageID   style=""height:500px;width:500px;"">
                                    </td>
                                </tr>
                                <tr>
                                <td>

                                    Many Many Happy Returns Of the Day
                                </td>
                                </tr>
                                </table>
                                </body>
                                </html>";
        * */

       string birthDay = @"<html>
<body>
<table width=""100%"">
<tr>
<td style=""font-style:arial; color:maroon; font-weight:bold;align:center;"" >
<font size=""1"" color=""blue""> </font> </br>
<img src=cid:myImageID style=""height:250px;width:250px;"">
</td>
</tr>
<tr>
<td>
<font face=""Comic Sans MS""> Many Many Happy Returns of the day!!!!!!!!!</font>

</td>
</tr>
</table>
</body>
</html>";
 


        string threeyear = @"<html>
                              <body>
                                <table width=""100%"">
                                <tr>
                                    <td style=""font-style:arial; color:maroon; font-weight:bold"" >
                                   Hi! <br>
                                    <img src=cid:myImageID   style=""height:500px;width:500px;"">
                                    </td>
                                </tr>
                                <tr>
                                <td>

                                    Congratulations for Completing three years
                                </td>
                                </tr>
                                </table>
                                </body>
                                </html>";

        string fiveyear = @"<html>
                              <body>
                                <table width=""100%"">
                                <tr>
                                    <td style=""font-style:arial; color:maroon; font-weight:bold"" >
                                   Hi! <br>
                                    <img src=cid:myImageID   style=""height:500px;width:500px;"">
                                    </td>
                                </tr>
                                <tr>
                                <td>

                                    Congratulations for Completing five years
                                </td>
                                </tr>
                                </table>
                                </body>
                                </html>";


        string newbie = @"<html>
                              <body>
                                <table width=""100%"">
                                <tr>
                                    <td style=""font-style:arial; color:maroon; font-weight:bold"" >
                                   Hi! <br>
                                    <img src=cid:myImageID   style=""height:500px;width:500px;"">
                                    </td>
                                </tr>
                                <tr>
                                <td>

                                   Welcome to Tavisca!!!!!!!!!!
                                </td>
                                </tr>
                                </table>
                                </body>
                                </html>";



        public string templateBirthBody()
        {
            string bdy = "<h2>DEAR&nbsp" + "avdhut" + "</h2></br>" + birthDay;
            
                return bdy;
        }
        public string templateThreeBody()
        {
            return threeyear;
        }

        public string templateFiveBody()
        {
            return fiveyear;
        }
        public string nextFifteenDayBDYRecordsTemplate(List<Employees> list)
        {
            string template = "";
            template += "<html><body><table>";
            template += "<th>Employee Id</th><th>Name</th><th>Date of Birthday</th><td>Email ID</td>";
            foreach (var x in list)
            {
                template += "<tr>";
                template += "<td>"+x.EmpID+"</td>"+x.EmpName+" "+x.EmpLastName+"<td>"+x.DateOfBirth.ToString()+"</td>";
                template += "<td>"+x.EmailId+"</td><td>"+x.Designation+"</td>";
                template += "<tr>";
            }
            template += "</body></table></html>";
            return template;
        }
    }
}
