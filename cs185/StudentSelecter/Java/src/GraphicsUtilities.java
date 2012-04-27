import java.awt.*;
import java.awt.font.*;
import java.awt.geom.*;

/**
 * Contains utility methods related to graphics.
 */
public final class GraphicsUtilities
{
	/**
	 * Draws the specified string centered both vertically and horizontally in the specified rectangle.
	 * This method calls {@link Graphics.setFont(Font)}.
	 * @param g The graphics context used to draw the string.
	 * @param string The text to draw.
	 * @param font The font used to draw the text.
	 * @param rectangle The rectangle to draw the text in.
	 */
	public static void drawStringInRectangle(Graphics2D g, String string, Font font, Rectangle rectangle)
    {
		g.setFont(font);
		
		if (string.length() == 0)
		{
			return;
		}
		
    	TextLayout textLayout = new TextLayout(string, font, g.getFontRenderContext());
    	Rectangle2D stringBounds = textLayout.getBounds();
    	float lineHeight = textLayout.getAscent() + textLayout.getDescent() + textLayout.getLeading();
    	
    	g.drawString(string,
    			rectangle.x + ((rectangle.width - (int)stringBounds.getWidth()) / 2),
    			rectangle.y + ((rectangle.height - (int)lineHeight) / 2) + textLayout.getAscent());
    }
}
