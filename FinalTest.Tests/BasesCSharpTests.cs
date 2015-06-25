﻿using System;
using NFluent;
using NUnit.Framework;

namespace FinalTest.Tests
{
    [TestFixture]
    public class BasesCSharpTests
    {
        [Test]
        public void CeTestDoitPasserSiEnvironnementOK()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void DéfinirUnTypeValeur()
        {
            var valeur1 = new TypeValeur(12);
            var valeur2 = new TypeValeur(12);

            Check.That(valeur1).IsEqualTo(valeur2);
            Check.That(typeof(TypeValeur).IsValueType).IsTrue();
        }

        [Test]
        public void DéfinirUnTypeRéférenceAvecEgalitéDeuxInstancesAyantLesMêmesPropriétés()
        {
            var valeur1 = new TypeReference(12);
            var valeur2 = new TypeReference(12);

            Check.That(valeur1).IsEqualTo(valeur2);
            Check.That(typeof(TypeReference).IsValueType).IsFalse();
        }

        [Test]
        public void DéfinirUneClasseRealisantUneMultiplication()
        {
            var multiplication = new Multiplication();

            Check.That(multiplication.PeutCalculer("2*3")).IsTrue();
            Check.That(multiplication.PeutCalculer("2+3")).IsFalse();
            Check.That(multiplication.Calculer("2*3")).IsEqualTo(6);
        }

        [Test]
        public void DéfinirUneClasseRealisantUneSomme()
        {
            var somme = new Somme();

            Check.That(somme.PeutCalculer("2+3")).IsTrue();
            Check.That(somme.PeutCalculer("2*3")).IsFalse();
            Check.That(somme.Calculer("2+3")).IsEqualTo(5);
        }

        //[Test]
        //public void DéfinirUneInterfaceStrategieAvec2ImplémentationsPrécédentesPasséesEnParamètreDUneClasseCliente()
        //{
        //    var multiplication = new Multiplication();
        //    var somme = new Somme();

        //    // La classe Calculatrice ne doit pas analyser l'opération reçue dans la méthode Calculer, elle doit s'appuyer sur les 2 implémentations passées en paramètre du constructeur
        //    var calculatrice = new Calculatrice(new IOperation[] { multiplication, somme });
        //    var resultatSomme = calculatrice.Calculer("1+2");
        //    var resultatProduit = calculatrice.Calculer("2*3");

        //    Check.That(resultatProduit).IsEqualTo(6);
        //    Check.That(resultatSomme).IsEqualTo(3);
        //}
    }

    public class Somme
    {
        public Boolean PeutCalculer(string p0)
        {
            Boolean retour = false;
            if (p0.Contains("+"))
            {
                retour = true;
            }
            if (p0.Contains("*") == true)
            {
                retour = false;
            }
            return retour;
        }

        public int Calculer(string s)
        {
            string i;
            i = s.Substring(0, 1);
            string j;
            j = s.Substring(2, 1);
            int num1 = int.Parse(i);
            int num2 = int.Parse(j);
            int retour = num1 + num2;
            return retour;
        }
    }

    public class Multiplication
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

    public struct TypeValeur
    {
        private int p;

        public TypeValeur(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
    }

    public class TypeReference
    {
        private int p;

        public TypeReference(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            TypeReference tReference = (TypeReference)obj;
            return (p == tReference.p);
        }
    }
}
