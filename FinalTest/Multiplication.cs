using System;

namespace FinalTest
{
    public class Multiplication : IOperation
    {
        public Boolean PeutCalculer(string p0)
        {
            Boolean retour = false;
            if (p0.Contains("*"))
            {
                retour = true;
            }
            if (p0.Contains("+") == true)
            {
                retour = false;
            }
            return retour;
        }

        int IOperation.Calculer(string s)
        {
            return Calculer(s);
        }

        bool IOperation.PeutCalculer(string s)
        {
            return PeutCalculer(s);
        }

        public int Calculer(string s)
        {
            string i;
            i = s.Substring(0, 1);
            string j;
            j = s.Substring(2, 1);
            int num1 = int.Parse(i);
            int num2 = int.Parse(j);
            int retour = num1*num2;
            return retour;
        }
    }
}