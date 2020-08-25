using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class EmailNotification : BaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        public override void SendExtra(string message)
        {
            Console.WriteLine("Wsyłano wiadomość Email: " + message);
        }
    }
}
