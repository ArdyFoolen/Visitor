using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDomain
{
    public interface IAllFruitVisitor : IFruitVisitor<Apple>, IFruitVisitor<Grape>, IFruitVisitor<Banana>
    {
    }
}
