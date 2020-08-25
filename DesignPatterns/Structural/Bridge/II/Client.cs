using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            MessageAbstraction message = new ShortMessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());

            message = new MessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());


            message = new ShortMessageAbstraction(new EmailGate());
            message.Send(Console.ReadLine());

            message = new MessageAbstraction(new EmailGate());
            message.Send(Console.ReadLine());

        }
    }
}
