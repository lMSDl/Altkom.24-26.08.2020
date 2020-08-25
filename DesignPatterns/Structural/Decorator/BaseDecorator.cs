using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private INotification Notification { get; }
        protected BaseDecorator(INotification notification)
        {
            Notification = notification;
        }

        public void Send(string message)
        {
            SendExtra(message);
            Notification.Send(message);
        }

        public abstract void SendExtra(string message);
    }
}
