using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Gestión_de_Recursos_Tecnológicos.src.soporte
{
    public abstract class MailService
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

       protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void sendMails(string subject , string body, List<string> recipientMail)
        {
            foreach (string mail in recipientMail)
            {
                sendMail(subject, body, mail);
            }
        }

        public void sendMail(string subject , string body, string mail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                mailMessage.To.Add(mail);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
               
            }
            catch (Exception ex)
            {
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            } 
        }
    }
}
