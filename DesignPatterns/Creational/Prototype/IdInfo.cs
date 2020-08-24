using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class IdInfo : ICloneable
    {
        public Guid IdNumber { get; set; }

        public IdInfo()
        {
            IdNumber = Guid.NewGuid();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
