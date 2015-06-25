using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class CompteCréé : IEvenementMetier
    {
        public int _autorisationDeCrédit;
        public string _numéroDeCompte;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numéroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CompteCréé compteCrééObj = obj as CompteCréé;

            if (compteCrééObj._numéroDeCompte != this._numéroDeCompte) return false;
            if (compteCrééObj._autorisationDeCrédit != this._autorisationDeCrédit) return false;

            return true;
        }
    }
}
