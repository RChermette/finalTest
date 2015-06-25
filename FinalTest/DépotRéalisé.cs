using System;
using FinalTest.Tests;

namespace FinalTest
{
    public class DépotRéalisé : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montantDepot;
        private readonly DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantDepot = montantDepot;
            _dateDepot = dateDepot;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            DépotRéalisé dépotRéalisé = obj as DépotRéalisé;

            if (dépotRéalisé._numéroDeCompte != this._numéroDeCompte) return false;
            if (dépotRéalisé._montantDepot != this._montantDepot) return false;
            if (dépotRéalisé._dateDepot != this._dateDepot) return false;

            return true;
        }

    }
}