namespace Petroules.WindowsCards
{
    /// <summary>
    /// Enumerates card types that can be drawn.
    /// </summary>
    public enum CardType
    {
        /// <summary>
        /// Draws the front of a card (a card face and suit is passed to cdtDraw).
        /// </summary>
        Front = 0,

        /// <summary>
        /// Draws the back of a card (a card background is passed to cdtDraw).
        /// </summary>
        Back = 1,

        /// <summary>
        /// Draws the inverted front of a card (a card face and suit is passed to cdtDraw).
        /// </summary>
        InvertedFront = 2,

        /// <summary>
        /// Draws a ghost card - the card paramter is ignored.
        /// </summary>
        Ghost = 3,

        /// <summary>
        /// Draws a rectangle of the background color.
        /// </summary>
        Remove = 4,

        /// <summary>
        /// Unused.
        /// </summary>
        Unused = 5,

        /// <summary>
        /// Draws an X.
        /// </summary>
        DeckX = 6,

        /// <summary>
        /// Draws an O.
        /// </summary>
        DeckO = 7
    }
}
