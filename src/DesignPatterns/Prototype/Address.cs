using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Address //: ICloneable
    {
        public string Street { get; set; }



        public Address Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
