import java.awt.*;
import java.util.*;

/**
 * Represents the animation shown when selecting a student name.
 */
public class SelectionAnimation
{
	/**
	 * The random object used to generate random numbers.
	 */
    private RandomExtensions random = new RandomExtensions();

    /**
     * The collection of circles that will be drawn.
     */
    private ArrayList<Rectangle> circleRects = new ArrayList<Rectangle>();

    /**
     * The font used to draw background characters.
     */
    private Font backgroundCharacterFont = new Font(Font.SERIF, Font.PLAIN, 17);

    /**
     * The font used to draw student names.
     */
    private Font studentNameFont = new Font(Font.SERIF, Font.PLAIN, 96);

    /**
     * The number of characters of a student's name to draw for the current paint operation.
     */
    private int nameCharacterCount = 0;

    /**
     * The last point at which we added another character of the student's name to the screen.
     */
    private Calendar lastDraw = Calendar.getInstance();

    /**
     * The location of the question mark.
     */
    private Point questionMarkLocation = new Point();

    /**
     * The last point at which the location of the question mark was changed.
     */
    private Calendar lastQuestionMarkChange = Calendar.getInstance();

    /**
     * The name of the student who has been selected to answer a question.
     */
    private String currentUser = "";
    
    /**
     * The state of the audio source; whether it is playing, paused or stopped.
     */
    private ALSourceState sourceState;

    /**
     * Initializes a new instance of the {@link SelectionAnimation} class.
     */
    public SelectionAnimation()
    {
        // Add 10 circle rectangles to our collection
        for (int i = 0; i < 10; i++)
        {
            this.circleRects.add(new Rectangle());
        }
    }
    
    /**
     * Gets the name of the student who has been selected to answer a question; an empty string if no one is currently selected.
     */
    public String getCurrentUser()
    {
    	return this.currentUser;
    }
    
    /**
     * Sets the name of the student who has been selected to answer a question.
     * @param currentUser The student who has been selected to answer a question; an empty string if no one is currently selected.
     */
    public void setCurrentUser(String currentUser)
    {
    	this.currentUser = currentUser;
        this.nameCharacterCount = 0;
    }
    
    /**
     * Gets the state of the audio source; whether it is playing, paused or stopped.
     */
    public ALSourceState getSourceState()
    {
    	return this.sourceState;
    }
    
    /**
     * Sets the state of the audio source; whether it is playing, paused or stopped.
     * @param sourceState The state of the audio source; whether it is playing, paused or stopped.
     */
    public void setSourceState(ALSourceState sourceState)
    {
    	this.sourceState = sourceState;
    }

    /**
     * Paints the animation.
     * @param g The graphics context used to draw the animation.
     * @param clientRectangle The client rectangle of the drawing surface.
     */
    public void paint(Graphics2D g, Rectangle clientRectangle)
    {
        // Clear the background color to black
        g.setColor(Color.BLACK);
        g.fillRect(clientRectangle.x, clientRectangle.y, clientRectangle.width, clientRectangle.height);

        // Draw the background artifacts and circles
        this.resetCircles(clientRectangle);
        this.drawCircles(g);
        this.drawBackgroundCharacters(g, clientRectangle);
        this.drawQuestionMark(g, clientRectangle);

        // Use crisp antialiased text rendering
        g.setRenderingHints(new RenderingHints(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON));

        // We draw a character every 0.05 seconds
        String studentName = this.currentUser.substring(0, Math.min(this.nameCharacterCount, this.currentUser.length()));

        // By default, the student name font is the one we have saved
        Font studentNameFont = this.studentNameFont;

        // If we're still playing the song, though, it should vibrate between the size of the name font and that value plus 4 pts
        if (this.getSourceState() == ALSourceState.PLAYING)
        {
            studentNameFont = new Font(Font.SERIF, Font.PLAIN, this.random.generateNumber((int)this.studentNameFont.getSize(), (int)this.studentNameFont.getSize() + 4));
        }

        // By default, the student name font is drawn in white.
        Color studentNameColor = Color.WHITE;

        // If we're still playing the song, though, it should be a random color
        if (this.getSourceState() == ALSourceState.PLAYING)
        {
            studentNameColor = this.random.generateColor();
        }

        // Draw the student's name in the center of the form with a random color
        g.setColor(studentNameColor);
        GraphicsUtilities.drawStringInRectangle(g, studentName, studentNameFont, clientRectangle);

        // If 0.05 seconds have passed, we can draw an additional character next time
        if (Calendar.getInstance().getTimeInMillis() - this.lastDraw.getTimeInMillis() > 50)
        {
            // The last time we added a character was NOW
            this.lastDraw = Calendar.getInstance();

            // Draw an additional character next time
            this.nameCharacterCount++;
        }
    }

    /**
     * Draws a question mark at a random location on the screen.
     * @param g The graphics context to draw the characters with.
     * @param clientRectangle The client rectangle of the drawing surface.
     */
    private void drawQuestionMark(Graphics2D g, Rectangle clientRectangle)
    {
        if (Calendar.getInstance().getTimeInMillis() - this.lastQuestionMarkChange.getTimeInMillis() > 500)
        {
            this.questionMarkLocation = new Point(this.random.generateNumber(100, clientRectangle.width - 100), this.random.generateNumber(100, clientRectangle.height - 100));
            this.lastQuestionMarkChange = Calendar.getInstance();
        }

        // Only draw the question mark if the music is playing and we don't have a name yet
        if (this.getSourceState() == ALSourceState.PLAYING && (this.currentUser == null || this.currentUser == ""))
        {
        	g.setRenderingHints(new RenderingHints(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON));
        	g.setColor(Color.WHITE);
        	g.setFont(this.studentNameFont);
            g.drawString("?", this.questionMarkLocation.x, this.questionMarkLocation.y);
        }
    }

    /**
     * Draws 50 random capital letters from the Latin alphabet in various colors and at various positions on the screen.
     * @param g The graphics context to draw the characters with.
     * @param clientRectangle The client rectangle of the drawing surface.
     */
    private void drawBackgroundCharacters(Graphics2D g, Rectangle clientRectangle)
    {
        // Only draw the background characters if the music is playing
        if (this.getSourceState() == ALSourceState.PLAYING)
        {
            for (int i = 0; i < 50; i++)
            {
            	g.setColor(this.random.generateColor());
            	g.setFont(this.backgroundCharacterFont);
                g.drawString(this.random.generateCharacterString('A', 'Z'), this.random.generateNumber(0, clientRectangle.width), this.random.generateNumber(0, clientRectangle.height));
            }
        }
    }

    /**
     * Goes through all the circle rectangles, checking whether any of them need to be reset to minimum size.
     * @param clientRectangle The client rectangle of the drawing surface.
     */
    private void resetCircles(Rectangle clientRectangle)
    {
        for (int i = 0; i < this.circleRects.size(); i++)
        {
            // If the circles' bounding rectangles are empty or they are too big and thus off-screen...
            if (this.circleRects.get(i).isEmpty() || this.circleRects.get(i).width > clientRectangle.width || this.circleRects.get(i).height > clientRectangle.height)
            {
                // ...then regenerate an empty bounding rectangle for the circle at a random point on the screen
                this.circleRects.set(i, new Rectangle(this.random.generateNumber(0, clientRectangle.width), this.random.generateNumber(0, clientRectangle.height), 0, 0));
            }
        }
    }

    /**
     * Draws each circle on the screen, but only if the music is playing.
     * @param g The graphics context to draw the circles with.
     */
    private void drawCircles(Graphics2D g)
    {
        // Only draw the expanding circles if the music is playing
        if (this.getSourceState() == ALSourceState.PLAYING)
        {
            for (int i = 0; i < this.circleRects.size(); i++)
            {
                // Draw each of our circles with a random color
            	g.setColor(this.random.generateColor());
                g.drawOval(this.circleRects.get(i).x, this.circleRects.get(i).y, this.circleRects.get(i).width, this.circleRects.get(i).height);

                // Inflate each circle by 3 pixels on each axis
                Rectangle grown = this.circleRects.get(i);
                grown.grow(3, 3);
                this.circleRects.set(i, grown);
            }
        }
    }
}
