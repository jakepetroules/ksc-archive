/**
 * Represents the OpenAL-relevant data of a wave file.
 */
public class WaveData
{
	/**
	 * The wave audio data.
	 */
	private byte[] audioData;
	
	/**
	 * The number of channels in the wave audio.
	 */
	private int channels;
	
	/**
	 * The number of bits in the wave audio.
	 */
	private int bits;
	
	/**
	 * The sample rate of the wave audio.
	 */
	private int rate;
	
	/**
	 * Initializes a new instance of the {@link WaveData} class.
	 * @param audioData The wave audio data.
	 * @param channels The number of channels in the wave audio.
	 * @param bits The number of bits in the wave audio.
	 * @param rate The sample rate of the wave audio.
	 */
	public WaveData(byte[] audioData, int channels, int bits, int rate)
	{
		this.audioData = audioData;
		this.channels = channels;
		this.bits = bits;
		this.rate = rate;
	}

	/**
	 * Gets the wave audio data.
	 * @return The wave audio data.
	 */
	public byte[] getAudioData()
	{
		return this.audioData;
	}

	/**
	 * Gets the number of channels in the wave audio.
	 * @return The number of channels in the wave audio.
	 */
	public int getChannels()
	{
		return this.channels;
	}

	/**
	 * Gets the number of bits in the wave audio.
	 * @return The number of bits in the wave audio.
	 */
	public int getBits()
	{
		return this.bits;
	}

	/**
	 * Gets the sample rate of the wave audio.
	 * @return The sample rate of the wave audio.
	 */
	public int getRate()
	{
		return this.rate;
	}
}
