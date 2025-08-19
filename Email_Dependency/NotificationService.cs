using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Dependency
{
    public class NotificationService
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public NotificationService(IEmailSender emailSender, ILogger logger)
        {
            _emailSender = emailSender;
            _logger = logger;
        }

        public void SendWelcomeEmail(string recipient)
        {
            string subject = "Welcome!";
            string body = "Thanks for signing up, " + recipient + "!";
            _emailSender.SendEmail(recipient, subject, body);
            _logger.Log($"Welcome email sent to {recipient}");
        }
    }
}
