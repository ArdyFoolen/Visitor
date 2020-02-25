using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAcyclicVisitorDomain
{
    public class Toyota : Car
    {
        public string Name { get; private set; }

        public Toyota(string name)
        {
            this.Name = name;
        }

        public void Accept(CarVisitor visitor)
        {
            if (visitor is CarVisitor<Toyota>)
                ((CarVisitor<Toyota>)visitor).Visit(this);
        }
    }
}
