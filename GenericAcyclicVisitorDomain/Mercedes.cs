using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAcyclicVisitorDomain
{
    public class Mercedes : Car
    {
        public string Name { get; private set; }

        public Mercedes(string name)
        {
            this.Name = name;
        }

        public void Accept(CarVisitor visitor)
        {
            if (visitor is CarVisitor<Mercedes>)
                ((CarVisitor<Mercedes>)visitor).Visit(this);
        }
    }
}
