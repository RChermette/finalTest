using System;
using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly string _numéroDeCompte;

        public CompteBancaire(CompteCréé newEvent, DépotRéalisé dépotRéalisé = null)
        {
            _numéroDeCompte = newEvent._numéroDeCompte;
        }
        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }
    }
}