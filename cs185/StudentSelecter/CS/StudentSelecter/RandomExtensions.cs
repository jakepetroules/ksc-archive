namespace StudentSelecter
{
    using System;
    using System.Collections;
    using System.Drawing;

    /// <summary>
    /// Provides extensions to the <see cref="Random"/> class.
    /// </summary>
    public static class RandomExtensions
    {
        /// <summary>
        /// Generates a random boolean value.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static bool GenerateBoolean(this Random random)
        {
            return random.NextDouble() > 0.5;
        }

        /// <summary>
        /// Generates a random Unicode character between code points <see cref="char.MinValue"/> and <see cref="char.MaxValue"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static char GenerateCharacter(this Random random)
        {
            return random.GenerateCharacter(char.MinValue, char.MaxValue);
        }

        /// <summary>
        /// Generates a random Unicode character between code points <paramref name="min"/> and <paramref name="max"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="min">The lowest Unicode code point that may be returned.</param>
        /// <param name="max">The highest Unicode code point that may be returned.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        public static char GenerateCharacter(this Random random, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("min is greater than max");
            }

            return (char)random.GenerateNumber(min, max);
        }

        /// <summary>
        /// Generates a random Unicode character between code points <see cref="char.MinValue"/> and <see cref="char.MaxValue"/>, inclusive,
        /// and returns the result as a string containing a single character.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static string GenerateCharacterString(this Random random)
        {
            return random.GenerateCharacter().ToString();
        }

        /// <summary>
        /// Generates a random Unicode character between code points <paramref name="min"/> and <paramref name="max"/>, inclusive,
        /// and returns the result as a string containing a single character.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="min">The lowest Unicode code point that may be returned.</param>
        /// <param name="max">The highest Unicode code point that may be returned.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        public static string GenerateCharacterString(this Random random, int min, int max)
        {
            return random.GenerateCharacter(min, max).ToString();
        }

        /// <summary>
        /// Retrieves a random enumeration constant from the specified enumeration type.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration to retrieve a random constant from.</typeparam>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException">The provided type is not an enumeration.</exception>
        public static T GenerateEnumValue<T>(this Random random)
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("The provided type is not an enumeration.");
            }

            Array values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(random.GenerateNumber(0, values.Length));
        }

        /// <summary>
        /// Generates a random color. The alpha transparency value is always 255.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static Color GenerateColor(this Random random)
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        /// <summary>
        /// Generates a random index in an array. The minimum value is 0 and the maximum value is the length of the array minus 1.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="array">The array whose bounds to generate the index for.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException">The array is empty.</exception>
        public static int GenerateIndex(this Random random, Array array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }

            return random.GenerateNumber(0, array.Length - 1);
        }

        /// <summary>
        /// Generates a random index in a collection. The minimum value is 0 and the maximum value is the number of elements in the collection minus 1.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="collection">The collection whose bounds to generate the index for.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException">The collection is empty.</exception>
        public static int GenerateIndex(this Random random, ICollection collection)
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("The collection is empty.");
            }

            return random.GenerateNumber(0, collection.Count - 1);
        }

        /// <summary>
        /// Generates a random color. The alpha transparency value will be varied.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static Color GenerateTransparentColor(this Random random)
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256), random.Next(256));
        }

        /// <summary>
        /// Generates a random integer between <see cref="int.MinValue"/> and <see cref="int.MaxValue"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static int GenerateNumber(this Random random)
        {
            return random.GenerateNumber(int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Generates a random number between <paramref name="min"/> and <paramref name="max"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="min">The minimum number that may be returned.</param>
        /// <param name="max">The maximum number that may be returned.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        public static int GenerateNumber(this Random random, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("min is greater than max");
            }

            if (min == int.MaxValue && max == int.MaxValue)
            {
                // If min and max are both int.MaxValue, return that
                return int.MaxValue;
            }
            else if (min > int.MinValue && max == int.MaxValue)
            {
                // If min is greater than int.MinValue AND max is int.MaxValue, trick it
                return random.Next(min - 1, max) + 1;
            }
            else if (min == int.MinValue && max == int.MaxValue)
            {
                // This gets a bit more difficult if we want the full range,
                // so simply offset one range by one, and then pick one
                int range1 = random.Next(min, max) + 1;
                int range2 = random.Next(min, max);

                // Decide which range to pick
                if (random.GenerateBoolean())
                {
                    return range1;
                }
                else
                {
                    return range2;
                }
            }

            return random.Next(min, max + 1);
        }

        /// <summary>
        /// Generates a random point whose X and Y coordinates are each in the range <see cref="int.MinValue"/> to <see cref="int.MaxValue"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <returns>See summary.</returns>
        public static Point GeneratePoint(this Random random)
        {
            return random.GeneratePoint(int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Generates a random point whose X and Y coordinates are each in the range <see cref="int.MinValue"/> to <see cref="int.MaxValue"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="min">The minimum value for the X or Y coordinate.</param>
        /// <param name="max">The maximum value for the X or Y coordinate.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        public static Point GeneratePoint(this Random random, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("min is greater than max");
            }

            return random.GeneratePoint(min, max, min, max);
        }

        /// <summary>
        /// Generates a random point whose X and Y coordinates are each in the range <see cref="int.MinValue"/> to <see cref="int.MaxValue"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="min">The minimum values for the X and Y coordinates.</param>
        /// <param name="max">The maximum values for the X and Y coordinates.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException">The X coordinate of either component is greater than its corresponding Y component.</exception>
        public static Point GeneratePoint(this Random random, Point min, Point max)
        {
            if (min.X > max.X || min.Y > max.Y)
            {
                throw new ArgumentException("The X coordinate of one component is greater than its corresponding Y component.");
            }

            return random.GeneratePoint(min.X, max.X, min.Y, max.Y);
        }

        /// <summary>
        /// Generates a random point whose X and Y coordinates are each in the range <see cref="int.MinValue"/> to <see cref="int.MaxValue"/>, inclusive.
        /// </summary>
        /// <param name="random">Reference to the <see cref="Random"/> instance.</param>
        /// <param name="minX">The minimum value for the X coordinate.</param>
        /// <param name="maxX">The maximum value for the X coordinate.</param>
        /// <param name="minY">The minimum value for the Y coordinate.</param>
        /// <param name="maxY">The maximum value for the Y coordinate.</param>
        /// <returns>See summary.</returns>
        /// <exception cref="ArgumentException">The X coordinate of either component is greater than its corresponding Y component.</exception>
        public static Point GeneratePoint(this Random random, int minX, int maxX, int minY, int maxY)
        {
            if (minX > maxX || minY > maxY)
            {
                throw new ArgumentException("The X coordinate of one component is greater than its corresponding Y component.");
            }

            return new Point(random.GenerateNumber(minX, maxX), random.GenerateNumber(minY, maxY));
        }
    }
}
