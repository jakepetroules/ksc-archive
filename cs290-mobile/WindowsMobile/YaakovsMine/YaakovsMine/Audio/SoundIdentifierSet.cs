namespace YaakovsMine
{
    /// <summary>
    /// Represents an OpenAL buffer and source.
    /// </summary>
    public class SoundIdentifierSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundIdentifierSet"/> class.
        /// </summary>
        /// <param name="buffer">The OpenAL sound buffer identifier.</param>
        /// <param name="source">The OpenAL sound source identifier.</param>
        public SoundIdentifierSet(int buffer, int source)
        {
            this.Buffer = buffer;
            this.Source = source;
        }

        /// <summary>
        /// Gets the OpenAL sound buffer identifier.
        /// </summary>
        public int Buffer
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the OpenAL sound source identifier.
        /// </summary>
        public int Source
        {
            get;
            private set;
        }
    }
}
