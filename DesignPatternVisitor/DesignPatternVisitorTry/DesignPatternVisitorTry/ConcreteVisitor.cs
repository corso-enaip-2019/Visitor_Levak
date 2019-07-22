using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitorTry
{
    public class ShoppingVisitor : IVisitor
    {
        private double total;

        public ShoppingVisitor()
        {
            total = 0;
        }

        public double GetTotal()
        {
            return total;
        }

        public void Visit(IVisitable visitable)
        {
            if (visitable == null)
            {
                throw new ArgumentException("Null visitable!");
            }
            if (visitable is ItemSoldInWeight)
            {
                var pw = (ItemSoldInWeight)visitable;
                total += pw.UnitPrice * pw.Weight;
            }
            else if (visitable is ItemSoldInPieces)
            {
                var pp = (ItemSoldInPieces)visitable;
                total += pp.UnitPrice * pp.NumberOfPieces;
            }
            else
            {
                throw new ArgumentException("Unknown visitable type!");
            }
        }
    }
}
