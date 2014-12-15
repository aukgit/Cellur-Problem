using System.Collections.Generic;
using CellPhone.Implementation;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class GlobalNetwork : CellPhone.CellPhonePattern.Interfaces.INetwork {
        public GlobalNetwork() {
            Networks = new List<LocalNetwork>(Global.DefaultNetworkPossible);
        }
        public List<LocalNetwork> Networks { get; set; }

        public bool ConnectToLocalNetwork(Phone phone) {
            throw new System.NotImplementedException();
        }

        public bool ConnectToLocalNetwork(Phone phone, LocalNetwork localNetwrok) {
            throw new System.NotImplementedException();
        }

        public bool RemovePhoneFromNetwork(Phone phone) {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Create a new one if none exist
        /// </summary>
        public LocalNetwork FindAnyNetwork() {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns null if not exist
        /// </summary>
        public LocalNetwork FindNetwork() {
            throw new System.NotImplementedException();
        }

        #region INetwork Members

        public int NetwrokId {
            get {
                throw new System.NotImplementedException();
            }
            set {
                throw new System.NotImplementedException();
            }
        }

        #endregion
    }
}
