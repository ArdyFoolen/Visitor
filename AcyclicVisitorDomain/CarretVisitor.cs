using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcyclicVisitorDomain
{
    public class CarretVisitor : ICarretVisitor, DegenerateVegetableVisitor
    {
        public void Visit(Carret carret)
        {
            Console.WriteLine($"Carret {carret.Name}");
        }
    }
}
