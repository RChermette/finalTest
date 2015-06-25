using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FinalTest
{
    public interface IOperation
    {
       Boolean PeutCalculer(string s);
        int Calculer(string s);
    }
}
