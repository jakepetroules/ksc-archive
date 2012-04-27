namespace YaakovsMine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a probability dictionary where the key is the object to be returned, and the value is the probability (1 in <em>n</em>) that that object will be returned.
    /// </summary>
    /// <typeparam name="T">The type of objects to return.</typeparam>
    public class ProbabilitySet<T> : Dictionary<T, decimal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProbabilitySet{T}"/> class.
        /// </summary>
        public ProbabilitySet()
        {
        }
        
        /// <summary>
        /// Gets or sets a value indicating whether default values (null or 0) can be returned if no elements
        /// happened to be selected, or whether at least one item in the set is gauranteed to be returned.
        /// </summary>
        public bool AllowBlanks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether duplicates are allowed to be returned if multiple values are drawn.
        /// </summary>
        public bool AllowDuplicates
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the number of 100%-probability items in the set.
        /// </summary>
        private int CountGuaranteed
        {
            get { return this.Where(p => p.Value == 1).Count(); }
        }

        /// <summary>
        /// Draws a random object from the probability set, taking the probabilities of each element into account.
        /// </summary>
        public T Draw()
        {
            return this.Draw(1).FirstOrDefault();
        }

        /// <summary>
        /// Draws a number of random objects from the probability set, taking the probabilities of each element into account.
        /// </summary>
        /// <param name="maximum">The maximum amount of objects that may be returned. The default is 1.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="maximum"/> is less than 1.</exception>
        public T[] Draw(int maximum)
        {
            if (this.CountGuaranteed > maximum)
            {
                throw new InvalidOperationException("You cannot draw less items than the number of items with 100% probabilities.");
            }

            // This IS a probability set, so we're obviously going to need one of these...
            Random random = new Random();

            // This stores the possible objects we can return
            List<T> possibilities = new List<T>();

            // While we have no possible objects to return, keep looping through
            do
            {
                // Go through each item in the set...
                foreach (KeyValuePair<T, decimal> pair in this)
                {
                    // Generate a boolean with the item's probability... if true, we add it to our list of possible selections
                    if (random.GenerateBoolean(pair.Value))
                    {
                        possibilities.Add(pair.Key);
                    }
                }
            }
            while (possibilities.Count == 0 && !this.AllowBlanks);

            // Select all the objects where their probability of being returned is 1 (100%)
            List<T> returned = new List<T>(this.Where(p => p.Value == 1).Select(p => p.Key));

            // Add some extra number of items other than the 100%s
            for (int i = 0; i < maximum; i++)
            {
                // Loop through, selecting a random item from our possibility list and adding it
                T x = default(T);
                do
                {
                    x = possibilities[random.GenerateIndex(possibilities)];
                }
                while (returned.Contains(x) && !this.AllowDuplicates);

                returned.Add(x);
            }

            return returned.ToArray();
        }

        /// <summary>
        /// Adds the specified key and value to the dictionary.
        /// </summary>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> is less than or equal to 0, or greater than 1.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="key"/> is null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the Dictionary{TKey,TValue}.</exception>
        public new void Add(T key, decimal value)
        {
            if (value <= 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException("value", "value must be greater than 0 and less than or equal to 1.");
            }

            base.Add(key, value);
        }
    }
}
