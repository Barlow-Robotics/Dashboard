using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FRC.NetworkTables;
using FRC.NetworkTables.Interop;

namespace Dash4572
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            NetworkTableInstance inst = NetworkTableInstance.Default;
//            inst.StartClient("10.45.72.2");
            inst.StartClient("192.168.68.152");

            DashboardDisplay mainForm = new DashboardDisplay();
            mainForm.NTINstance = inst;

            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);
        }
    }
}
