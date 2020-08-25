using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public ShortMessageAbstraction(IMessageSenderImplementation messageSender) : base(messageSender)
        {
        }

        public override void Send(string message)
        {
            if (message.Length > 10)
                Console.WriteLine("Wiadomość za długa");
            else
                base.Send(message);
        }
    }
}
