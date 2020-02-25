using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public class Apple : Fruit
    {
        public override void Accept(IFruitVisitor visitor)
        {
            if (visitor is IFruitVisitor<Apple>)
                ((IFruitVisitor<Apple>)visitor).Visit(this);
        }
    }
}
