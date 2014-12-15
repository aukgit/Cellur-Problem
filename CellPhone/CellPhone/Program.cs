using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CellPhone.CellPhonePattern.BluePrints;
using CellPhone.Implementation;

namespace CellPhone {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Global.Network = new GlobalNetwork();
            Global.PhoneNumbers = new List<long>();
            Global.NetworkIds = new List<int>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
