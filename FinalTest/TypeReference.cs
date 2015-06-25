using System;

namespace FinalTest
{
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