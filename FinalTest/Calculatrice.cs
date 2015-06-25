using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Calculatrice
    {
        private IOperation[] operation;
        public Calculatrice(IOperation[] operation)
        {
            this.operation = operation;
        }


        public int Calculer(string p0)
        {
            int retour = 0;
                foreach (var operation1 in operation)
                {
                    if(operation1.PeutCalculer(p0))
                    {
                       retour = operation1.Calculer(p0);
                    }
                }
            return retour;

        }
    }
}
