using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcyclicVisitorDomain
{
    public class Cucumber : Vegetable
    {
        public string Name { get; private set; }

        public Cucumber(string name)
        {
            this.Name = name;
        }

        public void Accept(DegenerateVegetableVisitor visitor)
        {
            if (visitor is ICucumberVisitor)
                ((ICucumberVisitor)visitor).Visit(this);
        }
    }
}
