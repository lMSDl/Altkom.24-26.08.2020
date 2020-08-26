using DesignPatterns.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : BaseLogger
    {
        protected override void ClosingConnection()
        {
            Console.WriteLine("Close File.");
        }

        protected override void LogMessage(string messageToLog)
        {
            Console.WriteLine("Appending Log message to file : " + messageToLog);
        }

        protected override IDisposable OpenConnection()
        {
            Console.WriteLine("Opening File.");
            return new Service();
        }

        protected override string Serialize(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
