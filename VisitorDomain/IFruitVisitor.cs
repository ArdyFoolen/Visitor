using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDomain
{
    public interface IFruitVisitor
    {
        void Visit(Apple apple);
        void Visit(Grape grape);
    }
}
