﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitest
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 

        /// Master Branch
        /// AUCH KEIN PLAN BRANCH
        [STAThread]
        static void Main()
        {
            int i = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            if (i == 1)
            {
                return;
            }

            if(i == 2)
            {
                return; // Oh no Error
            }
        }
    }
}
