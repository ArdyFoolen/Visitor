using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAcyclicVisitorDomain
{
    public interface CarVisitor
    {
    }
    public class CarVisitor<T> : CarVisitor
        where T: Car
    {
        public void Visit(Car car)
        {
            Console.WriteLine($"{car.GetType().Name} name: {car.Name}");
        }
        public void Visit(Bmw car)
        {
            Console.WriteLine($"{car.GetType().Name} name: {car.Name}");
        }
        public void Visit(Toyota car)
        {
            Console.WriteLine($"{car.GetType().Name} name: {car.Name}");
        }
    }
}
