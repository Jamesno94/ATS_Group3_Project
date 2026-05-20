using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace ATS_Group3_Project
{
    public class EmailManager
    {
        private readonly string senderEmail =
            ConfigurationManager.AppSettings["EmailAddress"];

        private readonly string senderPassword =
            ConfigurationManager.AppSettings["EmailPassword"];

        public bool SendPasswordResetEmail(
            string recipientEmail,
            string firstName,
            string resetCode)
        {
            try
            {
                MailMessage message = new MailMessage();

                message.From =
                    new MailAddress(senderEmail);

                message.To.Add(recipientEmail);

                message.Subject =
                    "ATS WindSync Password Reset";

                message.Body =
                    "Hello " + firstName + ",\n\n" +
                    "Your password reset code is:\n\n" +
                    resetCode + "\n\n" +
                    "This code expires in 15 minutes.";

                SmtpClient smtp =
                    new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials =
                    new NetworkCredential(
                        senderEmail,
                        senderPassword
                    );

                smtp.EnableSsl = true;

                smtp.Send(message);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}