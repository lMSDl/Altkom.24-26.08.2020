using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class BaseLogger
    {
        public void Log(object message)
        {
            string messageToLog = Serialize(message);
            var disposable = OpenConnection();
            LogMessage(messageToLog);
            CloseConnection(disposable);
        }

        private void CloseConnection(IDisposable disposable)
        {
            ClosingConnection();
            disposable?.Dispose();
        }

        protected abstract void ClosingConnection();
        protected abstract void LogMessage(string messageToLog);
        protected abstract IDisposable OpenConnection();
        protected abstract string Serialize(object message);
    }
}
