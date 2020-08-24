using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Addresses { get; set; }
        public IdInfo IdInfo { get; set; }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.IdInfo = (IdInfo)IdInfo.Clone();
            clone.Addresses = Addresses.Select(x => (string)x.Clone()).ToList();
            //clone.Addresses = Addresses.ToList();
            return clone;
        }
    }
}
