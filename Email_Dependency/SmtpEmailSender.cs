using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Dependency
{
    public class SmtpEmailSender : IEmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"[SMTP]Sending email to {to} with subject '{subject}' and body:\n{body}");
        }
    }
}
