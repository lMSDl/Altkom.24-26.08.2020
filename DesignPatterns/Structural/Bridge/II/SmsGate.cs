using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public class SmsGate : IMessageSenderImplementation
    {
        public const int MaxLength = 10;

        public void SendMessage(string message)
        {
            var splittedMessage = Enumerable.Range(0, message.Length / MaxLength)
                .Select(x => message.Substring(x * MaxLength, MaxLength));

            foreach (var item in splittedMessage)
            {
                Console.WriteLine($"Wiadomość została wysłana przez SMS: {item}");
            }
        }
    }
}
