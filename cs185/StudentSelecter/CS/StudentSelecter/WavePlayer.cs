namespace StudentSelecter
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using OpenTK.Audio;
    using OpenTK.Audio.OpenAL;

    /// <summary>
    /// Represents a wave file player.
    /// </summary>
    public sealed class WavePlayer
    {
        /// <summary>
        /// The OpenAL audio content used for playback.
        /// </summary>
        private AudioContext context;

        /// <summary>
        /// The OpenAL sound buffer identifier.
        /// </summary>
        private int buffer;

        /// <summary>
        /// The OpenAL sound source identifier.
        /// </summary>
        private int source;

        /// <summary>
        /// The source state listener thread.
        /// </summary>
        private Thread thread;

        /// <summary>
        /// Initializes a new instance of the <see cref="WavePlayer"/> class.
        /// </summary>
        /// <param name="fileName">The file to read audio data from.</param>
        public WavePlayer(string fileName)
            : this()
        {
            this.Load(fileName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavePlayer"/> class.
        /// </summary>
        /// <param name="stream">The stream to read audio data from.</param>
        public WavePlayer(Stream stream)
            : this()
        {
            this.Load(stream);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavePlayer"/> class.
        /// </summary>
        private WavePlayer()
        {
            this.context = new AudioContext();

            this.buffer = AL.GenBuffer();
            this.source = AL.GenSource();

            this.thread = new Thread(new ThreadStart(this.SourceStateListen));
            this.thread.Start();
        }

        /// <summary>
        /// Raised when the <see cref="SourceState"/> property changes.
        /// </summary>
        public event EventHandler SourceStateChanged = delegate { };

        /// <summary>
        /// Gets the state of the audio source; whether it is playing, paused or stopped.
        /// </summary>
        public ALSourceState SourceState
        {
            get
            {
                int state;
                AL.GetSource(this.source, ALGetSourcei.SourceState, out state);
                return (ALSourceState)state;
            }
        }

        /// <summary>
        /// Loads a wave/riff audio file.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        /// <param name="channels">The number of channels in the wave file.</param>
        /// <param name="bits">The number of bits per sample in the wave file.</param>
        /// <param name="rate">The sample rate of the wave file.</param>
        /// <returns>The sound data of the wave file.</returns>
        public static byte[] LoadWave(Stream stream, out int channels, out int bits, out int rate)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            using (BinaryReader reader = new BinaryReader(stream))
            {
                // RIFF header signature
                if (new string(reader.ReadChars(4)) != "RIFF")
                {
                    throw new NotSupportedException("Specified stream is not a wave file.");
                }

                int riff_chunck_size = reader.ReadInt32();

                if (new string(reader.ReadChars(4)) != "WAVE")
                {
                    throw new NotSupportedException("Specified stream is not a wave file.");
                }

                // WAVE header format signature
                if (new string(reader.ReadChars(4)) != "fmt ")
                {
                    throw new NotSupportedException("Specified wave file is not supported.");
                }

                int format_chunk_size = reader.ReadInt32();
                int audio_format = reader.ReadInt16();
                int num_channels = reader.ReadInt16();
                int sample_rate = reader.ReadInt32();
                int byte_rate = reader.ReadInt32();
                int block_align = reader.ReadInt16();
                int bits_per_sample = reader.ReadInt16();

                string data_signature = new string(reader.ReadChars(4));
                if (data_signature != "data")
                {
                    throw new NotSupportedException("Specified wave file is not supported.");
                }

                int data_chunk_size = reader.ReadInt32();

                channels = num_channels;
                bits = bits_per_sample;
                rate = sample_rate;

                return reader.ReadBytes((int)reader.BaseStream.Length - (int)reader.BaseStream.Position);
            }
        }

        /// <summary>
        /// Gets the OpenAL format specifier for the sound format with the specified number of channels and bits.
        /// </summary>
        /// <param name="channels">The number of channels in the sound format.</param>
        /// <param name="bits">The number of bits in the sound format.</param>
        /// <returns>See summary.</returns>
        public static ALFormat GetSoundFormat(int channels, int bits)
        {
            switch (channels)
            {
                case 1:
                    return bits == 8 ? ALFormat.Mono8 : ALFormat.Mono16;
                case 2:
                    return bits == 8 ? ALFormat.Stereo8 : ALFormat.Stereo16;
                default:
                    throw new NotSupportedException("The specified sound format is not supported.");
            }
        }

        /// <summary>
        /// Loads a wave file into the player.
        /// </summary>
        /// <param name="fileName">The name of the file to load.</param>
        public void Load(string fileName)
        {
            this.Load(File.Open(fileName, FileMode.Open));
        }

        /// <summary>
        /// Loads a wave file into the player.
        /// </summary>
        /// <param name="stream">The stream to load from.</param>
        public void Load(Stream stream)
        {
            int channels, bits_per_sample, sample_rate;
            byte[] sound_data = WavePlayer.LoadWave(stream, out channels, out bits_per_sample, out sample_rate);
            AL.BufferData(this.buffer, WavePlayer.GetSoundFormat(channels, bits_per_sample), sound_data, sound_data.Length, sample_rate);

            AL.Source(this.source, ALSourcei.Buffer, this.buffer);
        }

        /// <summary>
        /// Plays the loaded wave file.
        /// </summary>
        public void Play()
        {
            AL.SourcePlay(this.source);
        }

        /// <summary>
        /// Frees resources.
        /// </summary>
        public void Dispose()
        {
            if (this.thread != null && this.thread.IsAlive)
            {
                this.thread.Abort();
            }

            AL.SourceStop(this.source);
            AL.DeleteSource(this.source);
            AL.DeleteBuffer(this.buffer);
            this.context.Dispose();
        }

        /// <summary>
        /// Listens for changes to the source state and raises events.
        /// </summary>
        private void SourceStateListen()
        {
            try
            {
                ALSourceState lastSourceState = ALSourceState.Initial;
                while (true)
                {
                    if (lastSourceState != this.SourceState)
                    {
                        lastSourceState = this.SourceState;
                        this.SourceStateChanged(this, EventArgs.Empty);
                    }

                    Thread.Sleep(1);
                }
            }
            catch (ThreadAbortException)
            {
            }
        }
    }
}
