using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public class Grape : Fruit
    {
        public int NumberOfGrapes { get; set; }

        public override void Accept(IFruitVisitor visitor)
        {
            if (visitor is IFruitVisitor<Grape>)
                ((IFruitVisitor<Grape>)visitor).Visit(this);
        }
    }
}
