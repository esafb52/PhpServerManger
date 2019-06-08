using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ServerManger
{
    static class Program
    {
        private static readonly Mutex Mutex = new Mutex(true, "{2bf72dfc232-52af-4541-b219-1dc4a7143cde}");

        [STAThread]
        private static void Main()
        {

            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                Mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(@"در حال حاضر یک نمونه از برنامه در حال اجرا می باشد", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.ExitThread();
            }

        }
    }
}
