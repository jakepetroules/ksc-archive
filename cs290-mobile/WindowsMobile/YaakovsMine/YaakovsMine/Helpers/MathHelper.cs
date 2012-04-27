namespace YaakovsMine
{
    using System;

    /// <summary>
    /// Provides mathematical utility methods.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Restricts the value to fit within the specified range.
        /// </summary>
        /// <typeparam name="T">The type of the value to clamp.</typeparam>
        /// <param name="value">The value to clamp.</param>
        /// <param name="min">The minimum value that may be returned. If <paramref name="value"/> is less than this value, this value will be returned.</param>
        /// <param name="max">The maximum value that may be returned. If <paramref name="value"/> is greater than this value, this value will be returned.</param>
        public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0)
            {
                return min;
            }
            else if (value.CompareTo(max) > 0)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="a">A number whose square root is to be found.</param>
        public static decimal Sqrt(decimal a)
        {
            return (decimal)Math.Sqrt((double)a);
        }

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="a">A number whose logarithm is to be found.</param>
        public static decimal Log10(decimal a)
        {
            return (decimal)Math.Log10((double)a);
        }

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A number to be raised to a power.</param>
        /// <param name="y">A number that specifies a power.</param>
        public static decimal Pow(decimal x, decimal y)
        {
            return (decimal)Math.Pow((double)x, (double)y);
        }
    }
}
