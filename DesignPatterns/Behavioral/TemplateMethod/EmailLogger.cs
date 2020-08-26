using DesignPatterns.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : BaseLogger
    {
        protected override void ClosingConnection()
        {
        }

        protected override void LogMessage(string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        protected override IDisposable OpenConnection()
        {
            return null;
        }

        protected override string Serialize(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
