namespace YaakovsMine
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a read-only generic collection of key/value pairs.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        /// <summary>
        /// The wrapped dictionary.
        /// </summary>
        private IDictionary<TKey, TValue> dictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyDictionary{TKey,TValue}"/> class.
        /// </summary>
        /// <param name="dictionary">The dictionary to wrap.</param>
        public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
        {
            this.dictionary = dictionary;
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="ICollection{T}"/>.
        /// </summary>
        /// <remarks>The number of elements contained in the <see cref="ICollection{T}"/>.</remarks>
        public int Count
        {
            get { return this.dictionary.Count; }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="ICollection{T}"/> is read-only.
        /// </summary>
        /// <remarks><c>true</c> if the <see cref="ICollection{T}"/> is read-only; otherwise, <c>false</c>.</remarks>
        public bool IsReadOnly
        {
            get { return true; }
        }

        /// <summary>
        /// Gets an <see cref="ICollection{T}"/> containing the keys of the <see cref="IDictionary{TKey,TValue}"/>.
        /// </summary>
        /// <returns>An <see cref="ICollection{T}"/> containing the keys of the object that implements <see cref="IDictionary{TKey,TValue}"/>.</returns>
        public ICollection<TKey> Keys
        {
            get { return this.dictionary.Keys; }
        }

        /// <summary>
        /// Gets an <see cref="ICollection{T}"/> containing the values in the <see cref="IDictionary{TKey,TValue}"/>.
        /// </summary>
        /// <returns>An <see cref="ICollection{T}"/> containing the values in the object that implements <see cref="IDictionary{TKey,TValue}"/>.</returns>
        public ICollection<TValue> Values
        {
            get { return this.dictionary.Values; }
        }

        /// <summary>
        /// Gets the element with the specified key. Setting a value always throws a <see cref="NotSupportedException"/>.
        /// </summary>
        /// <param name="key">The key of the element to get or set.</param>
        /// <returns>The element with the specified key.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="key"/> is <c>null</c>.</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and <paramref name="key"/> is not found.</exception>
        /// <exception cref="NotSupportedException">The property is set and the <see cref="IDictionary{TKey,TValue}"/> is read-only.</exception>
        public TValue this[TKey key]
        {
            get { return this.dictionary[key]; }
            set { throw new NotSupportedException(); }
        }

        /// <summary>
        /// This method always throws a <see cref="NotSupportedException"/>.
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// This method always throws an <see cref="NotSupportedException"/>.
        /// </summary>
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// This method always throws an <see cref="NotSupportedException"/>.
        /// </summary>
        public void Clear()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Determines whether the <see cref="ICollection{T}"/> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="ICollection{T}"/>.</param>
        /// <returns><c>true</c> if item is found in the <see cref="ICollection{T}"/>; otherwise, <c>false</c>.</returns>
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return this.dictionary.Contains(item);
        }

        /// <summary>
        /// Determines whether the <see cref="IDictionary{TKey,TValue}"/> contains an element with the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the <see cref="IDictionary{TKey,TValue}"/>.</param>
        /// <returns><c>true</c> if the <see cref="IDictionary{TKey,TValue}"/> contains an element with the key; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="key"/> is <c>null</c>.</exception>
        public bool ContainsKey(TKey key)
        {
            return this.dictionary.ContainsKey(key);
        }

        /// <summary>
        /// Copies the elements of the <see cref="ICollection{T}"/> to an <see cref="Array"/>, starting at a particular <see cref="Array"/> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from <see cref="ICollection{T}"/>. The <see cref="Array"/> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="arrayIndex"/> is less than 0.</exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="array"/> is multidimensional.  -or- <paramref name="arrayIndex"/> is equal to or greater than the
        /// length of array.  -or- The number of elements in the source <see cref="ICollection{T}"/> is greater than the available
        /// space from <paramref name="arrayIndex"/> to the end of the destination array.  -or- Type <typeparamref name="T"/> cannot
        /// be cast automatically to the type of the destination array.
        /// </exception>
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            this.dictionary.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="IEnumerator{T}"/> that can be used to iterate through the collection.</returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return this.dictionary.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.dictionary.GetEnumerator();
        }

        /// <summary>
        /// This method always throws an <see cref="NotSupportedException"/>.
        /// </summary>
        public bool Remove(TKey key)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// This method always throws an <see cref="NotSupportedException"/>.
        /// </summary>
        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="value">When this method returns, the value associated with the specified key, if
        /// the key is found; otherwise, the default value for the type of the value
        /// parameter. This parameter is passed uninitialized.</param>
        /// <returns><c>true</c> if the object that implements <see cref="IDictionary{TKey,TValue}"/>
        /// contains an element with the specified key; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="key"/> is <c>null</c>.</exception>
        public bool TryGetValue(TKey key, out TValue value)
        {
            return this.dictionary.TryGetValue(key, out value);
        }   
    }
}
