using DesignPatterns.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class DbLogger : BaseLogger
    {
        protected override void ClosingConnection()
        {
            Console.WriteLine("Closing DB connection.");
        }

        protected override void LogMessage(string messageToLog)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + messageToLog);
        }

        protected override IDisposable OpenConnection()
        {
            Console.WriteLine("Connecting to Database.");
            return new Service();
        }

        protected override string Serialize(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
