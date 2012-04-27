namespace YaakovsMine
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Provides utility methods for keyboard input.
    /// </summary>
    public sealed class InputHelper
    {
        /// <summary>
        /// An array of the possible keys we can track.
        /// </summary>
        private Keys[] keys;

        /// <summary>
        /// The state of all keys on the keyboard as of the last call to <see cref="Update"/>.
        /// </summary>
        private Dictionary<Keys, bool> lastKeyboardState;

        /// <summary>
        /// The current state of all keys on the keyboard.
        /// </summary>
        private Dictionary<Keys, bool> currentKeyboardState;

        /// <summary>
        /// Initializes a new instance of the <see cref="InputHelper"/> class.
        /// </summary>
        public InputHelper()
        {
            this.keys = ReimplementationHelper.EnumGetValues<Keys>(typeof(Keys));
        }

        /// <summary>
        /// Determines whether the specified key is pressed down.
        /// </summary>
        /// <param name="key">The key to check.</param>
        public bool IsKeyPressed(Keys key)
        {
            this.Ensure();
            return this.lastKeyboardState[key] && this.currentKeyboardState[key];
        }

        /// <summary>
        /// Determines whether the specified key is newly pressed. This is useful for an operation that should happen only once when a key is pressed down.
        /// </summary>
        /// <param name="key">The key to check.</param>
        public bool IsNewlyPressed(Keys key)
        {
            this.Ensure();
            return !this.lastKeyboardState[key] && this.currentKeyboardState[key];
        }

        /// <summary>
        /// Determines whether the specified key was pressed, but no longer is. This is useful for an operation that should happen only once when a key is released.
        /// </summary>
        /// <param name="key">The key to check.</param>
        public bool WasPressed(Keys key)
        {
            this.Ensure();
            return this.lastKeyboardState[key] && !this.currentKeyboardState[key];
        }

        /// <summary>
        /// Updates the state of the internal keyboard dictionaries by polling the keyboard.
        /// </summary>
        public void Update()
        {
            Dictionary<Keys, bool> dict = this.GetKeyboardState();
            this.lastKeyboardState = this.currentKeyboardState ?? dict;
            this.currentKeyboardState = dict;
        }

        /// <summary>
        /// Ensures that the internal keyboard dictionaries are not null by calling <see cref="Update"/> if necessary.
        /// </summary>
        private void Ensure()
        {
            if (this.lastKeyboardState == null || this.currentKeyboardState == null)
            {
                this.Update();
            }
        }

        /// <summary>
        /// Gets a dictionary containing the state of each key on the keyboard.
        /// </summary>
        private Dictionary<Keys, bool> GetKeyboardState()
        {
            Dictionary<Keys, bool> keys = new Dictionary<Keys, bool>();
            foreach (Keys key in this.keys)
            {
                keys.Add(key, Native.GetKeyState(key));
            }

            return keys;
        }
    }
}
