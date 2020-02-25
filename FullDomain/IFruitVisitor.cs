using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public interface IFruitVisitor
    {
    }

    public interface IFruitVisitor<T> : IFruitVisitor
        where T: Fruit
    {
        void Visit(T fruit);
    }
}
