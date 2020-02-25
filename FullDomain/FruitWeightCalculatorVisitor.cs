using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public class FruitWeightCalculatorVisitor : IAllFruitVisitor
    {
        public decimal WeightInGrams { get; private set; }

        public void Visit(Apple apple)
        {
            WeightInGrams += appleWeight;
        }

        public void Visit(Grape grape)
        {
            WeightInGrams += grape.NumberOfGrapes * singleGrapeWeight;
        }

        public void Visit(Banana banana)
        {
            WeightInGrams += banana.NumberOfFingers * bananaWeightPerFinger;
        }

        private readonly decimal appleWeight = 150m;
        private readonly decimal singleGrapeWeight = 0.6m;
        private readonly decimal bananaWeightPerFinger = 125.0m;
    }
}
