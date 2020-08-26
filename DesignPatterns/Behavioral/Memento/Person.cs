using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
           /* BirthDate = state.BirthDate;
            Name = state.Name;*/

            var propertyInfos = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.CanWrite).ToList();

            propertyInfos.ForEach(p =>
            {
                var oldValue = p.GetValue(state, null);
                p.SetValue(this, oldValue, null);
            });
        }

    }
}
