using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellPhone.CellPhonePattern.BluePrints;

namespace CellPhone.Implementation {
    public static class Global {
        private static int _defaultNetworkPossible = 50;
        private static int _defaultPhonesPossible = 50;
        public static GlobalNetwork Network { get; set; }

        public static int DefaultNetworkPossible
        {
            get { return _defaultNetworkPossible; }
            set { _defaultNetworkPossible = value; }
        }

        public static int DefaultPhonesPossible
        {
            get { return _defaultPhonesPossible; }
            set { _defaultPhonesPossible = value; }
        }
    }
}
