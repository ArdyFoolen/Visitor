using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDomain
{
    public class FruitVisitor : IFruitVisitor
    {
        public void Visit(Apple apple)
        {
            Console.WriteLine($"Apple {apple.Name}");
        }

        public void Visit(Grape grape)
        {
            Console.WriteLine($"Grape {grape.Name}");
        }
    }
}
