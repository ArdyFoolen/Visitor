using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcyclicVisitorDomain
{
    public interface Vegetable
    {
        void Accept(DegenerateVegetableVisitor visitor);
    }
}
