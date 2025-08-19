using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Dependency
{
    public class ConsoleEmailSender : IEmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"[Console] Email to {to}:\nSubject: {subject}\nBody: {body}");
        }
    }
}
