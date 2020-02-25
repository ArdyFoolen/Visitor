using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public static class FruitExtensions
    {
        public static IEnumerable<T> Pick<T>(this IEnumerable<Fruit> fruits)
            where T: Fruit
        {
            FruitPicker<T> picker = new FruitPicker<T>();
            foreach (Fruit fruit in fruits) fruit.Accept(picker);
            return picker.Fruit;
        }
    }
}
