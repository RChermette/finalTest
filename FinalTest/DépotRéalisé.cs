using System;
using FinalTest.Tests;

namespace FinalTest
{
    public class D�potR�alis� : IEvenementMetier
    {
        private readonly string _num�roDeCompte;
        private readonly Montant _montantDepot;
        private readonly DateTime _dateDepot;

        public D�potR�alis�(string num�roDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _num�roDeCompte = num�roDeCompte;
            _montantDepot = montantDepot;
            _dateDepot = dateDepot;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            D�potR�alis� d�potR�alis� = obj as D�potR�alis�;

            if (d�potR�alis�._num�roDeCompte != this._num�roDeCompte) return false;
            if (d�potR�alis�._montantDepot != this._montantDepot) return false;
            if (d�potR�alis�._dateDepot != this._dateDepot) return false;

            return true;
        }

    }
}