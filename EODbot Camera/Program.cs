﻿using System;
using System.Windows.Forms;

namespace EODbot_Camera {
    static class Program {
        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
