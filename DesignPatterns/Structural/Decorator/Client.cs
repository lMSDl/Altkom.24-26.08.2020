using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Client
    {
        public static bool SendSMS { get; set; }
        public static bool SendEmail { get; set; }

        public static void Execute()
        {
            var test = Console.ReadLine();

            var notification = (INotification)new Notification();
            SendSMS = SendEmail = true;
            if (SendSMS)
                notification = new SmsNotification(notification);
            if (SendEmail)
                notification = new EmailNotification(notification);

            notification.Send(test);
        }
    }
}
