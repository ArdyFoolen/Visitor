using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcyclicVisitorDomain
{
    public class CucumberVisitor : ICucumberVisitor, DegenerateVegetableVisitor
    {
        public void Visit(Cucumber cucumber)
        {
            Console.WriteLine($"Cucumber {cucumber.Name}");
        }
    }
}
