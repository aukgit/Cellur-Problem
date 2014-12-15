using System.Collections.Generic;
using System.Linq;
using CellPhone.Implementation;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class GlobalNetwork : CellPhone.CellPhonePattern.Interfaces.INetwork {
        public GlobalNetwork() {
            MaxPhonePossibleOnNetwork = Global.DefaultPhonesPossible;
            Networks = new List<LocalNetwork>(Global.DefaultNetworkPossible);
        }

        public int MaxPhonePossibleOnNetwork { get; private set; }
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


        public LocalNetwork CreateNewNetwork() {
            var network = new LocalNetwork();
            Networks.Add(network);
            return network;
        }

        /// <summary>
        /// Create a new one if none exist
        /// </summary>
        public LocalNetwork GetAvailableNetwork() {
            if (Networks.Count == 0) {
                return CreateNewNetwork();
            } else {
                var networkAvailableForPhone = Networks.FirstOrDefault(n => n.Phones.Count < MaxPhonePossibleOnNetwork);
                if (networkAvailableForPhone != null) {
                    return networkAvailableForPhone;

                } else {
                    return CreateNewNetwork();
                }
            }
        }

        /// <summary>
        /// Returns null if not exist
        /// </summary>
        public LocalNetwork FindNetwork(int networkId) {
            return Networks.FirstOrDefault(n => n.NetworkId == networkId);
        }

        #region INetwork Members

        public int NetwrokId { get; set; }

        #endregion
    }
}
