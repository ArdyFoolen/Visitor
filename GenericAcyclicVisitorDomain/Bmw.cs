using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAcyclicVisitorDomain
{
    public class Bmw : Car
    {
        public string Name { get; private set; }

        public Bmw(string name)
        {
            this.Name = name;
        }

        public void Accept(CarVisitor visitor)
        {
            if (visitor is CarVisitor<Bmw>)
                ((CarVisitor<Bmw>)visitor).Visit(this);
        }
    }
}
