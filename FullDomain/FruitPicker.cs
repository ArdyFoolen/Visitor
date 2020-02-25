using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public class FruitPicker<T> : IFruitVisitor<T>
        where T: Fruit
    {
        public List<T> Fruit { get; private set; }

        public FruitPicker()
        {
            Fruit = new List<T>();
        }

        public void Visit(T fruit)
        {
            Fruit.Add(fruit);
        }
    }
}
