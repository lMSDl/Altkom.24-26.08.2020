using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverB : Observer<int>
    {
        public override void OnNext(int value)
        {
            if(value == 0 || value >=2)
            {
                Console.WriteLine("ObserverB: reaguje na zmianę");
            }
        }
    }
}
