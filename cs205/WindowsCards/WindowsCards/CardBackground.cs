#define USE_XP_BACKGROUND_NAMES

namespace Petroules.WindowsCards
{
    /// <summary>
    /// Enumerates available card backgrounds.
    /// </summary>
    public enum CardBackground
    {
        /// <remarks>
        /// The color argument of cdtDraw will only have an effect when using this card type.
        /// </remarks>
        Crosshatch = 53,

        /// <summary>
        /// The sky background (weave1 in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Sky
#else
        Weave1
#endif
        = 54,

        /// <summary>
        /// The mineral background (weave2 in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Mineral
#else
        Weave2
#endif
        = 55,

        /// <summary>
        /// The fish background (robot in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Fish
#else
        Robot
#endif
        = 56,

        /// <summary>
        /// The frog background (flowers in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Frog
#else
        Flowers
#endif
        = 57,

        /// <summary>
        /// The moonflower background (vine1 in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Moonflower
#else
        Vine1
#endif
        = 58,

        /// <summary>
        /// The island background (vine2 in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Island
#else
        Vine2
#endif
        = 59,

        /// <summary>
        /// The squares background (fish1 in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Squares
#else
        Fish1
#endif
        = 60,

        /// <summary>
        /// The magenta background (fish2 in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Magenta
#else
        Fish2
#endif
        = 61,

        /// <summary>
        /// The sand dunes background (shells in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        SandDunes
#else
        Shells
#endif
        = 62,

        /// <summary>
        /// The space background (castle in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Space
#else
        Castle
#endif
        = 63,

        /// <summary>
        /// The lines background (island in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        Lines
#else
        Island
#endif
        = 64,

        /// <summary>
        /// The toy cars background (card hand in older versions of Windows).
        /// </summary>
#if USE_XP_BACKGROUND_NAMES
        ToyCars
#else
        CardHand
#endif
        = 65,

        /// <summary>
        /// Unused.
        /// </summary>
        Unused = 66,

        /// <summary>
        /// The X background.
        /// </summary>
        TheX = 67,

        /// <summary>
        /// The O background.
        /// </summary>
        TheO = 68
    }
}
