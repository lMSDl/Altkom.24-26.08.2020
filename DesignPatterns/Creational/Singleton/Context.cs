using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Context
    {
        private Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja singletona");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public static Context Instance { get; } = new Context();

        //private static Context instance;
        //private static object locker = new object();

        //public static Context GetInstace()
        //{
        //    lock (locker)
        //    {
        //        if (instance == null)
        //            instance = new Context();
        //    }
        //    return instance;
        //}


        public string GetSettings(string key)
        {
            return _settings[key];
        }
    }
}
