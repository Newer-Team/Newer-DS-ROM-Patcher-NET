using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Newer_DS_Patcher
{
    static class Program
    {
        // Written by Skawo 21/12/2017
        // Rewrite of RoadrunnerWMC's Python version.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
