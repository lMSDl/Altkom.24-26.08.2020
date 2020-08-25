using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.II
{
    public static class PersonAdaptation
    {
        public static Person ToPerson(this DbPerson person)
        {
            var adapter = new DbPersonAdapter(person);
            return new Person() { Name = adapter.Name, Age = adapter.Age };
        }
    }
}
