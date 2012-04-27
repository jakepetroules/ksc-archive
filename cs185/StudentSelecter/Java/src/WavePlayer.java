import java.io.*;
import java.nio.*;
import javax.swing.event.*;
import net.java.games.joal.*;
import net.java.games.joal.util.*;

/**
 * Represents a wave file player.
 */
public final class WavePlayer
{
	/**
     * The list of listeners to the source state changed event.
     */
    protected EventListenerList listenerList = new EventListenerList();
    
    /**
     * The OpenAL audio content used for playback.
     */
    private AL context;

    /**
     * The OpenAL sound buffer identifier.
     */
    private int[] buffer = new int[1];

    /**
     * The OpenAL sound source identifier.
     */
    private int[] source = new int[1];
    
    /**
     * The source state listener thread.
     */
    private Thread thread;

    /**
     * Initializes a new instance of the {@link WavePlayer} class.
     * @param fileName The file to read audio data from.
     * @throws IOException An I/O exception occurs.
     * @throws OpenALException An OpenAL exception occurs.
     */
    public WavePlayer(String fileName) throws IOException, OpenALException
    {
    	this();
        this.load(fileName);
    }

    /**
     * Initializes a new instance of the {@link WavePlayer} class.
     * @param stream The stream to read audio data from.
     * @throws IOException An I/O exception occurs.
     * @throws OpenALException An OpenAL exception occurs.
     */
    public WavePlayer(InputStream stream) throws IOException, OpenALException
    {
    	this();
        this.load(stream);
    }

    /**
     * Initializes a new instance of the {@link WavePlayer} class.
     * @throws OpenALException An OpenAL exception occurs.
     */
    private WavePlayer() throws OpenALException
    {
        this.context = ALFactory.getAL();
        
        ALut.alutInit();
        
        this.context.alGenBuffers(1, this.buffer);
        this.context.alGenSources(1, this.source);
        
        this.thread = new Thread(new Runnable()
        {
			@Override
			public void run()
			{
				WavePlayer.this.sourceStateListen();
			}
		});
        
        this.thread.start();
    }

    /**
     * Gets the state of the audio source; whether it is playing, paused or stopped.
     */
    public ALSourceState getSourceState()
    {
        int[] state = new int[1];
        this.context.alGetSourcei(this.source[0], AL.AL_SOURCE_STATE, state);
        return ALSourceState.fromInt(state[0]);
    }
    
    /**
     * Reads an 8-bit ASCII string from a stream.
     * @param stream The stream to read from.
     * @param count The number of bytes (e.g. the number of characters or the length of the string) to read.
     * @return The string, constructed from the individual bytes.
     * @throws IOException An I/O error occurs.
     */
    public static String readByteString(InputStream stream, int count) throws IOException
    {
    	char[] bytes = new char[count];
    	for (int i = 0; i < count; i++)
    	{
    		bytes[i] = (char)stream.read();
    	}
    	
    	return new String(bytes);
    }
    
    /**
     * Loads a wave/riff audio file.
     * Note that we have to reverse bytes in here because Java's streams use big endian format, whereas the WAVE file format is in little endian.
     * @param stream The stream to read from.
     * @return The data of the wave file.
     * @throws IOException 
     * @exception IllegalArgumentException {@link stream} is null -or- the stream is not a wave file -or- the wave file is not supported.
     * @exception IOException An I/O error occurs.
     */
    public static WaveData loadWave(InputStream stream) throws IOException
    {
        if (stream == null)
        {
            throw new IllegalArgumentException("stream is null");
        }

        DataInputStream reader = new DataInputStream(stream);

        // RIFF header signature
        if (!WavePlayer.readByteString(stream, 4).equals("RIFF"))
        {
            throw new IllegalArgumentException("Specified stream is not a wave file.");
        }

        @SuppressWarnings("unused")
		int riff_chunck_size = Integer.reverseBytes(reader.readInt());

        if (!WavePlayer.readByteString(stream, 4).equals("WAVE"))
        {
            throw new IllegalArgumentException("Specified stream is not a wave file.");
        }

        // WAVE header format signature
        if (!WavePlayer.readByteString(stream, 4).equals("fmt "))
        {
            throw new IllegalArgumentException("Specified wave file is not supported.");
        }

        @SuppressWarnings("unused")
		int format_chunk_size = Integer.reverseBytes(reader.readInt());
        @SuppressWarnings("unused")
		int audio_format = Short.reverseBytes(reader.readShort());
        int num_channels = Short.reverseBytes(reader.readShort());
        int sample_rate = Integer.reverseBytes(reader.readInt());
        @SuppressWarnings("unused")
		int byte_rate = Integer.reverseBytes(reader.readInt());
        @SuppressWarnings("unused")
		int block_align = Short.reverseBytes(reader.readShort());
        int bits_per_sample = Short.reverseBytes(reader.readShort());

        if (!WavePlayer.readByteString(stream, 4).equals("data"))
        {
            throw new IllegalArgumentException("Specified wave file is not supported.");
        }

        @SuppressWarnings("unused")
		int data_chunk_size = Integer.reverseBytes(reader.readInt());

        byte[] data = new byte[reader.available()];
        if (data.length == reader.read(data))
        {
        	return new WaveData(data, num_channels, bits_per_sample, sample_rate);
        }
        else
        {
        	return null;
        }
    }

    /**
     * Gets the OpenAL format specifier for the sound format with the specified number of channels and bits.
     * @param channels The number of channels in the sound format.
     * @param bits The number of bits in the sound format.
     */
    public static int getSoundFormat(int channels, int bits)
    {
        switch (channels)
        {
            case 1:
                return bits == 8 ? AL.AL_FORMAT_MONO8 : AL.AL_FORMAT_MONO16;
            case 2:
                return bits == 8 ? AL.AL_FORMAT_STEREO8 : AL.AL_FORMAT_STEREO16;
            default:
                throw new IllegalArgumentException("The specified sound format is not supported.");
        }
    }

    /**
     * Loads a wave file into the player.
     * @param fileName The name of the file to load.
     * @throws IOException An I/O exception occurs.
     */
    public void load(String fileName) throws IOException
    {
        this.load(new FileInputStream(fileName));
    }

    /**
     * Loads a wave file into the player.
     * @param stream The stream to load from.
     * @throws IOException An I/O exception occurs.
     */
    public void load(InputStream stream) throws IOException
    {
        WaveData sound_data = WavePlayer.loadWave(stream);
        ByteBuffer buffer = BufferUtils.newByteBuffer(sound_data.getAudioData().length);
        buffer.put(sound_data.getAudioData());
        this.context.alBufferData(this.buffer[0], WavePlayer.getSoundFormat(sound_data.getChannels(), sound_data.getRate()), buffer, sound_data.getAudioData().length, sound_data.getRate());

        this.context.alSourcei(this.source[0], AL.AL_BUFFER, this.buffer[0]);
    }

    /**
     * Plays the loaded wave file.
     * @throws InterruptedException The thread is interrupted while sleeping.
     */
    public void play()
    {
        this.context.alSourcePlay(this.source[0]);
    }

    /**
     * Frees resources.
     */
    public void dispose()
    {
    	this.context.alDeleteBuffers(1, this.buffer);
    	this.context.alDeleteSources(1, this.source);
        ALut.alutExit();
    }
    
    public void addSourceStateChangedListener(SourceStateChangedListener listener)
    {
    	this.listenerList.add(SourceStateChangedListener.class, listener); 
    }
    
    public void removeSourceStateChangedListener(SourceStateChangedListener listener)
    {
    	this.listenerList.remove(SourceStateChangedListener.class, listener);
    }
    
    private void fireSourceStateChanged(SourceStateChangedEvent event)
    {
    	Object[] listeners = listenerList.getListenerList();
    	
    	// Each listener occupies two elements - the first is the listener class and the second is the listener instance
    	for (int i = 0; i < listeners.length; i += 2)
    	{
    		if (listeners[i] == SourceStateChangedListener.class)
    		{
    			((SourceStateChangedListener)listeners[i + 1]).sourceStateChanged(event);
    		}
    	}
    }
    
    /**
     * Listens for changes to the source state and raises events.
     */
    private void sourceStateListen()
    {
        try
        {
            ALSourceState lastSourceState = ALSourceState.INITIAL;
            while (true)
            {
                if (lastSourceState != this.getSourceState())
                {
                    lastSourceState = this.getSourceState();
                    this.fireSourceStateChanged(new SourceStateChangedEvent(this));
                }

                Thread.sleep(1);
            }
        }
        catch (InterruptedException e)
        {
        }
    }
}