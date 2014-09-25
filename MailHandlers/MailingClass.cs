using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net;
using System.IO;
using System.Configuration;
using System.Net.Mail;
using ExceptionHandler;


namespace MailHandlers
{
    public class MailingClass
    {
        string mailServerName = ConfigurationSettings.AppSettings["mailServerName"];
        Int32 port = Convert.ToInt32(ConfigurationSettings.AppSettings["port"]);
        string fromEmailIdStr = ConfigurationSettings.AppSettings["fromEmailID"];
        string password = ConfigurationSettings.AppSettings["password"];

        public void SendMail(string from_Email, string to_Email, string CCList, string body, string from_Name, string Subject, string imagePath,string bodyImagePath)
        {

            try
            {
                MailMessage mail = new MailMessage();

                mail.IsBodyHtml = true;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

                LinkedResource theEmailImage = new LinkedResource(imagePath);
                theEmailImage.ContentId = "myImageID";
                LinkedResource theBodyImage = new LinkedResource(bodyImagePath);
                theBodyImage.ContentId = "myBodyId";

                htmlView.LinkedResources.Add(theEmailImage);
                htmlView.LinkedResources.Add(theBodyImage);

                mail.AlternateViews.Add(htmlView);

                mail.From = new MailAddress(from_Email, from_Name);

                mail.To.Add(to_Email);

                mail.CC.Add(CCList);

                mail.Subject = Subject;

                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(fromEmailIdStr, password);
                SmtpClient smtp = new SmtpClient(mailServerName, port);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = cred;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                ExceptionLogger log = new ExceptionLogger();
                log.DoLog(ex);

            }


        }
        public void SendToAdmin(string from_Email, string to_Email, string body, string from_Name, string Subject)
        {

            try
            {
                MailMessage mail = new MailMessage();

                //set the HTML format to true
                mail.IsBodyHtml = true;

                mail.From = new MailAddress(from_Email, from_Name);
                mail.Body = body;
                //set the "to" email address
                mail.To.Add(to_Email);

                //set the Email subject
                mail.Subject = Subject;

                //set the SMTP info
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(fromEmailIdStr, password);
                SmtpClient smtp = new SmtpClient(mailServerName, port);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = cred;
                //send the email
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                ExceptionLogger log = new ExceptionLogger();
                log.DoLog(ex);
            }
        }
    }
}
