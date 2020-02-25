using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDomain
{
    public class Apple : Fruit
    {
        public string Name { get; private set; }

        public Apple(string name)
        {
            this.Name = name;
        }

        public void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
