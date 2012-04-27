namespace YaakovsMine
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// Contains native methods.
    /// </summary>
    public static class Native
    {
        /// <summary>
        /// Gets the pressed state of a key.
        /// </summary>
        /// <param name="key">The key to get the state of.</param>
        /// <returns><c>true</c> if the key is pressed; <c>false</c> if it is not.</returns>
        /// <exception cref="NotSupportedException">The operating system is not Windows NT or Windows CE.</exception>
        public static bool GetKeyState(Keys key)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    return Native.GetKeyStateWIN(key);
                case PlatformID.WinCE:
                    return Native.GetKeyStateCE(key);
                default:
                    throw new NotSupportedException("The operating system must be Windows NT or Windows CE.");
            }
        }

        /// <summary>
        /// Gets the pressed state of a key.
        /// </summary>
        /// <param name="key">The key to get the state of.</param>
        /// <returns><c>true</c> if the key is pressed; <c>false</c> if it is not.</returns>
        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
        private static extern bool GetKeyStateWIN([MarshalAs(UnmanagedType.I4)] Keys key);
        
        /// <summary>
        /// Gets the pressed state of a key.
        /// </summary>
        /// <param name="key">The key to get the state of.</param>
        /// <returns><c>true</c> if the key is pressed; <c>false</c> if it is not.</returns>
        [DllImport("coredll.dll", EntryPoint = "GetAsyncKeyState")]
        private static extern bool GetKeyStateCE([MarshalAs(UnmanagedType.I4)] Keys key);
    }
}
