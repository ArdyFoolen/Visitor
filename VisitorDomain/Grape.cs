using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDomain
{
    public class Grape : Fruit
    {
        public string Name { get; private set; }

        public Grape(string name)
        {
            this.Name = name;
        }

        public void Accept(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
