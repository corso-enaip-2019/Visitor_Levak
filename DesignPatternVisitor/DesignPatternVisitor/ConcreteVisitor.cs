using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    //Implementiamo il ConcreteVisitor del pattern imnplementando l'interfaccia IVisitor
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

        public void Visit(ItemSoldInPieces visitable)
        {
            if (visitable == null)
            {
                throw new ArgumentException("Null visitable!");
            }
            total += visitable.NumberOfPieces * visitable.UnitPrice;
        }

        public void Visit(ItemSoldInWeight visitable)
        {
            if (visitable == null)
            {
                throw new ArgumentException("Null visitable!");
            }
            total += visitable.Weight * visitable.UnitPrice;
        }
    }
}