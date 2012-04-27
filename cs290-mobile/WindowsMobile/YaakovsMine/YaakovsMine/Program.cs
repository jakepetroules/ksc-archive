namespace YaakovsMine
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main entry class for the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        public static void Main()
        {
            Application.Run(new MainForm());
        }
    }
}