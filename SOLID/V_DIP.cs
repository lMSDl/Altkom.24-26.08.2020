using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IMessage
    {
        void SendMessage();
    }

    class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            SendSms();
        }

        public void SendSms()
        {
            Console.WriteLine("Wysyłanie SMS...");
        }
    }

    class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMms()
        {
            Console.WriteLine("Wysyłanie MMS...");
        }
        public void SendMessage()
        {
            SendMms();
        }

    }

    class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public byte[] Attachment { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Wysyłanie Email...");
        }
        public void SendMessage()
        {
            SendEmail();
        }

    }

    class Messenger
    {
        public ICollection<IMessage> Messages { get; set; }
        public void SendMessages()
        {
            foreach (var message in Messages)
            {
                message.SendMessage();
            }
        }
    }
}
