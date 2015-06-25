using System;
using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly string _num�roDeCompte;

        public CompteBancaire(CompteCr�� newEvent, D�potR�alis� d�potR�alis� = null)
        {
            _num�roDeCompte = newEvent._num�roDeCompte;
        }
        public static IEnumerable<IEvenementMetier> Ouvrir(string num�roDeCompte, int autorisationDeCr�dit)
        {
            yield return new CompteCr��(num�roDeCompte, autorisationDeCr�dit);
        }
    }
}