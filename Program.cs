﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login_Form());
            Login_Form flogin = new Login_Form();

            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main_Form());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
