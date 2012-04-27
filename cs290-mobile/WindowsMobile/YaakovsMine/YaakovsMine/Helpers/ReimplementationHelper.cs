namespace YaakovsMine
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Re-implements various methods that are not included in the .NET Compact Framework.
    /// </summary>
    public static class ReimplementationHelper
    {
        /// <summary>
        /// Gets an array of the values in an enumeration type.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="enumeration">A <see cref="Type"/> object representing the type of the enumeration.</param>
        public static T[] EnumGetValues<T>(Type enumeration)
        {
            List<T> enumerations = new List<T>();
            foreach (FieldInfo fieldInfo in enumeration.GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                T key = (T)fieldInfo.GetValue(enumeration);
                if (!enumerations.Contains(key))
                {
                    enumerations.Add(key);
                }
            }

            return enumerations.ToArray();
        }
    }
}
