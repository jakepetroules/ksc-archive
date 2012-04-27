/**
 * Source state information, can be retrieved by AL.Source() with ALSourcei.SourceState.
 */
public enum ALSourceState
{
	/**
	 * Null state.
	 */
	NULL(0),
	
	/**
	 * Default State when loaded, can be manually set with AL.SourceRewind().
	 */
    INITIAL(4113),
    
    /**
     * The source is currently playing.
     */
    PLAYING(4114),
    
    /**
     * The source has paused playback.
     */
    PAUSED(4115),
    
    /**
     * The source is not playing.
     */
    STOPPED(4116);
    
    /**
     * The underlying value of the enumeration constant.
     */
    public final int value;
    
    /**
     * Initializes a new instance of the {@link ALSourceState} enumeration.
     * @param value The underlying value of the enumeration constant.
     */
    private ALSourceState(int value)
    {
    	this.value = value;
    }
    
    /**
     * Returns the {@link ALSourceState} constant corresponding to {@link value}.
     * @param value The value to get the constant for.
     * @exception IllegalArgumentException value is not a value ALSourceState value.
     */
    public static ALSourceState fromInt(int value)
    {
    	ALSourceState[] values = ALSourceState.values();
    	for (int i = 0; i < values.length; i++)
    	{
    		if (values[i].value == value)
    		{
    			return values[i];
    		}
    	}
    	
    	throw new IllegalArgumentException("value is not a value ALSourceState value.");
    }
}
