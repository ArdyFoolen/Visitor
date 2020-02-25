using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcyclicVisitorDomain
{
    public class Carret : Vegetable
    {
        public string Name { get; private set; }

        public Carret(string name)
        {
            this.Name = name;
        }

        public void Accept(DegenerateVegetableVisitor visitor)
        {
            if (visitor is ICarretVisitor)
                ((ICarretVisitor)visitor).Visit(this);
        }
    }
}
