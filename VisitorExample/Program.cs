using AcyclicVisitorDomain;
using GenericAcyclicVisitorDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular Visitor pattern");
            VisitorDomain.IFruitVisitor visitor = new VisitorDomain.FruitVisitor();
            VisitorDomain.Fruit apple = new VisitorDomain.Apple("Golden delicious");
            VisitorDomain.Fruit grape = new VisitorDomain.Grape("Merlot");

            apple.Accept(visitor);
            grape.Accept(visitor);

            Console.WriteLine("=======================");
            Console.WriteLine("Acyclic Visitor pattern");
            DegenerateVegetableVisitor acyclicVisitor = new CarretVisitor();
            Vegetable carret = new Carret("Red");
            carret.Accept(acyclicVisitor);

            acyclicVisitor = new CucumberVisitor();
            Vegetable cucumber = new Cucumber("Green");
            cucumber.Accept(acyclicVisitor);

            Console.WriteLine("=======================");
            Console.WriteLine("Generic Acyclic Visitor pattern");
            CarVisitor carVisitor = new CarVisitor<Toyota>();
            Toyota toyota = new Toyota("Corrolla");
            toyota.Accept(carVisitor);

            carVisitor = new CarVisitor<Bmw>() as CarVisitor;
            Bmw bmw = new Bmw("4");
            bmw.Accept(carVisitor);

            carVisitor = new CarVisitor<Mercedes>() as CarVisitor;
            Mercedes mercedes = new Mercedes("default");
            mercedes.Accept(carVisitor);

            Console.WriteLine("=======================");
            Console.WriteLine("Full Visitor pattern");
            List<FullDomain.Fruit> fruits = new List<FullDomain.Fruit>()
            {
                new FullDomain.Grape() { NumberOfGrapes = 3 },
                new FullDomain.Banana() { NumberOfFingers = 4 },
                new FullDomain.Apple(),
                new FullDomain.Grape() { NumberOfGrapes = 6 },
                new FullDomain.Banana() { NumberOfFingers = 3 },
                new FullDomain.Apple(),
                new FullDomain.Apple(),
                new FullDomain.Grape() { NumberOfGrapes = 7 },
                new FullDomain.Grape() { NumberOfGrapes = 4 },
                new FullDomain.Banana() { NumberOfFingers = 3 }
            };

            List<FullDomain.Apple> allApples = FullDomain.FruitExtensions.Pick<FullDomain.Apple>(fruits).ToList(); // Because of namespace clashes I call extension method like this
            Console.WriteLine($"Number of apples visited {allApples.Count}");

            List<FullDomain.Grape> allGrapes = FullDomain.FruitExtensions.Pick<FullDomain.Grape>(fruits).ToList(); // Because of namespace clashes I call extension method like this
            Console.WriteLine($"Number of grape objects visited {allGrapes.Count}, number of grapes {allGrapes.Sum(s => s.NumberOfGrapes)}");

            List<FullDomain.Banana> allBananas = FullDomain.FruitExtensions.Pick<FullDomain.Banana>(fruits).ToList(); // Because of namespace clashes I call extension method like this
            Console.WriteLine($"Number of bananas visited {allBananas.Count}, number of fingers {allBananas.Sum(s => s.NumberOfFingers)}");

            FullDomain.FruitWeightCalculatorVisitor weightCalculator = new FullDomain.FruitWeightCalculatorVisitor();
            fruits.ForEach(fruit => fruit.Accept(weightCalculator));
            Console.WriteLine($"Weight of fruits {weightCalculator.WeightInGrams}");

            Console.Write("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
