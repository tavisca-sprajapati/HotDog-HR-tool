using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

namespace MailHandlers
{
    public class MailingClass
    {
        public void SendMail(string from_Email, string to_Email, string body, string from_Name, string Subject, string imagePath, string SMTP_IP, Int32 SMTP_Server_Port)
        {

            try
            {
                MailMessage mail = new MailMessage();

                //set the HTML format to true
                mail.IsBodyHtml = true;

                //create Alrternative HTML view
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

                //Add Image
                LinkedResource theEmailImage = new LinkedResource(imagePath);
                theEmailImage.ContentId = "myImageID";

                //Add the Image to the Alternate view
                htmlView.LinkedResources.Add(theEmailImage);

                //Add view to the Email Message
                mail.AlternateViews.Add(htmlView);

                //set the "from email" address and specify a friendly 'from' name
                mail.From = new MailAddress(from_Email, from_Name);

                //set the "to" email address
                mail.To.Add(to_Email);

                //set the Email subject
                mail.Subject = Subject;

                //set the SMTP info
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential("apandit@tavisca.com", "ilovevintagegrape");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = cred;
                //send the email
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                try
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt", true);
                    file.WriteLine(ex.ToString());
                    file.Close();
                }
                catch (Exception ex2)
                {
                    //E.ToString();
                }

            }


        }
        public void SendToAdmin(string from_Email, string to_Email, string body, string from_Name, string Subject)
        {

            try
            {
                MailMessage mail = new MailMessage();

                //set the HTML format to true
                mail.IsBodyHtml = true;

                ////create Alrternative HTML view
                //AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

                ////Add Image
                //LinkedResource theEmailImage = new LinkedResource(imagePath);
                //theEmailImage.ContentId = "myImageID";

                //Add the Image to the Alternate view
                //htmlView.LinkedResources.Add(theEmailImage);

                ////Add view to the Email Message
                //mail.AlternateViews.Add(htmlView);

                //set the "from email" address and specify a friendly 'from' name
                mail.From = new MailAddress(from_Email, from_Name);

                //set the "to" email address
                mail.To.Add(to_Email);

                //set the Email subject
                mail.Subject = Subject;

                //set the SMTP info
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential("apandit@tavisca.com", "ilovevintagegrape");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = cred;
                //send the email
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                try
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt", true);
                    file.WriteLine(ex.ToString());
                    file.Close();
                }
                catch (Exception ex2)
                {
                    //E.ToString();
                }

            }
        }
    }
}
