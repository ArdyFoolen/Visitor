using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public abstract class Fruit
    {
        public abstract void Accept(IFruitVisitor visitor);
    }
}
