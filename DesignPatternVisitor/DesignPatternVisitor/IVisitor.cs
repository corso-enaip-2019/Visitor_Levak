using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    public interface IVisitor
    {
        void Visit(ItemSoldInWeight visitable);
        void Visit(ItemSoldInPieces visitable);
    }
}
