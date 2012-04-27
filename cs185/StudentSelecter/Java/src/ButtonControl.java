import java.awt.*;

/**
 * Represents a simple AWT button control.
 */
public final class ButtonControl
{
	/**
     * The bounding rectangle of the button.
     */
    private Rectangle rectangle = new Rectangle();
    
    /**
     * The text on the button.
     */
    private String label;
    
    /**
     * Whether the button is enabled.
     */
    private boolean enabled;
    
    /**
     * Initializes a new instance of the {@link ButtonControl} class with the specified label.
     * @param label The text on the button.
     */
	public ButtonControl(String label)
    {
        this.setLabel(label);
        this.setEnabled(true);
        this.setSize(new Dimension(125, 25));
    }

	/**
	 * Gets the location of the button on the screen.
	 * @return The location of the button on the screen.
	 */
    public Point getLocation()
    {
    	return this.getRectangle().getLocation();
    }
    
    /**
     * Sets the location of the button on the screen.
     * @param location The location of the button on the screen.
     */
    public void setLocation(Point location)
    {
    	this.setRectangle(new Rectangle(location, this.getRectangle().getSize()));
    }

    /**
     * Gets the size of the button in pixels.
     * @return The size of the button in pixels.
     */
    public Dimension getSize()
    {
    	return this.getRectangle().getSize();
    }
    
    /**
     * Sets the size of the button in pixels.
     * @param size The size of the button in pixels.
     */
    public void setSize(Dimension size)
    {
    	this.setRectangle(new Rectangle(this.getRectangle().getLocation(), size));
    }

    /**
     * Gets the bounding rectangle of the button.
     * @return The bounding rectangle of the button.
     */
    public Rectangle getRectangle()
    {
    	return this.rectangle;
    }
    
    /**
     * Sets the bounding rectangle of the button.
     * @param rectangle The bounding rectangle of the button.
     */
    public void setRectangle(Rectangle rectangle)
    {
    	this.rectangle = rectangle;
    }
    
    /**
     * Gets the text on the button.
     * @return The text on the button.
     */
    public String getLabel()
    {
    	return this.label;
    }
    
    /**
     * Sets the text on the button.
     * @param label The text on the button.
     */
    public void setLabel(String label)
    {
    	this.label = label;
    }
    
    /**
     * Gets a value indicating whether the button is enabled.
     * @return Whether the button is enabled.
     */
    public boolean isEnabled()
    {
    	return this.enabled;
    }
    
    /**
     * Sets a value indicating whether the button is enabled.
     * @param enabled Whether the button is enabled.
     */
    public void setEnabled(boolean enabled)
    {
    	this.enabled = enabled;
    }

    /**
     * Draws the button.
     * @param g The graphics context used to draw the button.
     */
    public void draw(Graphics2D g)
    {
    	g.setColor(Color.BLACK);
        g.fillRect(this.getRectangle().x, this.getRectangle().y, this.getRectangle().width, this.getRectangle().height);
        
        g.setColor(Color.WHITE);
        g.drawRect(this.getRectangle().x, this.getRectangle().y, this.getRectangle().width, this.getRectangle().height);

        g.setRenderingHints(new RenderingHints(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON));
        g.setColor(this.isEnabled() ? Color.WHITE : Color.GRAY);
        GraphicsUtilities.drawStringInRectangle(g, this.getLabel(), new Font(Font.SANS_SERIF, Font.PLAIN, 17), this.getRectangle());
    }
}