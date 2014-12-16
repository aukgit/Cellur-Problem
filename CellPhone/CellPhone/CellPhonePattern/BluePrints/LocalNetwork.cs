using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CellPhone.CellPhonePattern.Interfaces;
using CellPhone.Implementation;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class LocalNetwork : CellPhone.CellPhonePattern.Interfaces.INetwork {
    
        public LocalNetwork() {
            Phones = new List<Phone>(Global.DefaultPhonesPossible);
            var rnd = new Random();
            again: 
            
            int id = rnd.Next();
            // first check if any network id exist in the global
            if (Global.NetworkIds.Any(n => n == id)) {
                goto again;
            }
            // creates a new network id for this network.
            this.NetworkId = id;
            Global.NetworkIds.Add(id);
        }
        public int NetworkId { get; set; }

        /// <summary>
        /// Connected cell phones in this network
        /// </summary>
        public List<Phone> Phones { get; set; }

   

        public int CurrentPhonesConnected { get; set; }

        public bool RemovePhone(long phoneNumber) {
            var phoneExist = FindPhone(phoneNumber);
            if (phoneExist != null) {
                Phones.Remove(phoneExist);
                return true;
            }
            return false;
        }

        public bool RemovePhone(Phone phone) {
            var phoneExist = FindPhone(phone);
            if (phoneExist != null) {
                Phones.Remove(phoneExist);
                Global.PhoneNumbers.Remove(phoneExist.PhoneNumber);
                return true;
            }
            return false;
        }

        /// <summary>
        /// If doesn't find returns null
        /// </summary>
        public Phone FindPhone(Phone phone) {
            return Phones.FirstOrDefault(n => n == phone);
        }

        public Phone FindPhone(long phoneNumber) {
            return Phones.FirstOrDefault(n => n.PhoneNumber == phoneNumber);
        }

        /// <summary>
        /// if successfully connected then true
        /// Checks first if phone already exist or not
        /// </summary>
        public bool ConnectNetwrok(Phone phone) {
            if (MaxCapacity <= (Phones.Count + 1)) {
                var phoneExist = FindPhone(phone);
                if (phoneExist == null) {
                    // phone doesn't exist
                    Phones.Add(phone);
                    return true;
                }
            }
            return false;
        }

        public int MaxCapacity { get; set; }

        /// <summary>
        /// if successfully connected then true
        /// Doesn't check if exist
        /// </summary>
        public bool ConnectNetwrok(Phone phone, bool dontCheckIfExist) {
            if (MaxCapacity <= (Phones.Count + 1)) {
                // phone doesn't exist
                Phones.Add(phone);
                return true;
            }
            return false;
        }

        #region INetwork Members

        private int NetwrokId { get; set; }

        int INetwork.NetwrokId {
            get { return this.NetwrokId; }
            set { this.NetwrokId = value; }
        }

        #endregion
    }
}
