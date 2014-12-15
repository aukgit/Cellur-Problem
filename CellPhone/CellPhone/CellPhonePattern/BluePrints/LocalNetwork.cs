using System.Collections.Generic;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class LocalNetwork {
        public int NetworkId {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// Connected cell phones in this network
        /// </summary>
        public List<Phone> Phones {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public int MaxCapacity {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public int CurrentPhonesConnected {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public bool RemovePhone(long phoneNumber) {
            throw new System.NotImplementedException();
        }

        public bool RemovePhone(Phone phone) {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// If doesn't find returns null
        /// </summary>
        public Phone FindPhone(Phone phone) {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// if successfully connected then true
        /// </summary>
        public bool ConnectNetwrok(Phone phone) {
            throw new System.NotImplementedException();
        }
    }
}
