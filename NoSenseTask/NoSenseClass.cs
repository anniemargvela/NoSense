using System;
using System.Collections.Generic;
using System.Text;

namespace NoSenseTask
{
    static class NoSenseClass
    {
        public static T ThisDoesntMakeAnySense<T>(this IEnumerable<T> list, Func<T, bool> Predicate, Func<T> Creator)
        {
            ValidateParameters(list, Predicate, Creator);

            foreach (var elem in list)
            {
                if (Predicate(elem)) return elem;
            }

            return Creator();
        }

        private static void ValidateParameters<T>(IEnumerable<T> list, Func<T, bool> Predicate, Func<T> Creator)
        {
            if (list == null)
                throw new NullReferenceException("List pointer is NULL");
            if (Predicate == null)
                throw new NullReferenceException("Predicate pointer is NULL");
            if (Creator == null)
                throw new NullReferenceException("Creator delegate pointer is NULL");
        }
    }
}
