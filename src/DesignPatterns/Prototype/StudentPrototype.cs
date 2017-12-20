using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class StudentPrototype : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address _Address{ get; set; }

        public StudentPrototype()
        {
            _Address = new Address();
        }

        public object Clone()
        {
            var clone = (StudentPrototype)this.MemberwiseClone();
            clone._Address = _Address.Clone();
            return clone;
        }

        public void BeginExcercise()
        {

        }
    }
}
