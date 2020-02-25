using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public class Banana : Fruit
    {
        public int NumberOfFingers { get; set; }
        public override void Accept(IFruitVisitor visitor)
        {
            if (visitor is IFruitVisitor<Banana>)
                ((IFruitVisitor<Banana>)visitor).Visit(this);
        }
    }
}
