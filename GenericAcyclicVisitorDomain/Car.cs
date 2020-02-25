using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAcyclicVisitorDomain
{
    public interface Car
    {
        string Name { get; }
        void Accept(CarVisitor visitor);
    }
}
