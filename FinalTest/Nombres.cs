﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get { return _keyValuePairs.Where(pair => pair.Value % 2 == 0).Select(pair => pair.Value); }
        }

        public String TexteNombresImpairs
        {
            get
            {
                return _keyValuePairs.Where(x => x.Value%2 != 0)
                    .OrderBy(x => x.Value)
                    .Select(x => x.Key).Aggregate((i, j) => i + ", " + j);
            }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return _keyValuePairs.Where(x => x.Key.Length > 5).Select(x => x.Key).First(); } 
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get
            {
                return _keyValuePairs.Where(x => x.Value > 3).OrderBy(x => x.Value).Select(x => x.Value).Take(4);
            }
        }
    }
}
