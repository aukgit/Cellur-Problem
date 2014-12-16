using System;
using System.Linq;
using System.Windows.Forms;
using CellPhone.CellPhonePattern.Interfaces;
using CellPhone.Implementation;
using CellPhone.UI.Inheritable;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class Phone : IFlashingBehaviour, INetwork, ISms {

        public Phone(long phoneNumber, PhoneInstance phoneInstance) {
            if (Global.PhoneNumbers.Any(n => n == phoneNumber)) {
                throw new Exception("you can't create a phone with existing number.");
            }
            TryToGetOnline();
            this.PhoneInstance = phoneInstance;
            this.PhoneNumber = phoneNumber;
            Global.PhoneNumbers.Add(phoneNumber);
        }

        public Phone(long phoneNumber, PhoneInstance phoneInstance, LocalNetwork network) {
            if (Global.PhoneNumbers.Any(n => n == phoneNumber)) {
                throw new Exception("you can't create a phone with existing number.");
            }
            network.ConnectNetwrok(this);
            this.PhoneInstance = phoneInstance;
            this.PhoneNumber = phoneNumber;
            Global.PhoneNumbers.Add(phoneNumber);
        }

        public void DisplayInterface() {
            if (PhoneInstance == null) {
                PhoneInstance = new PhoneInstance(this);
            }
            PhoneInstance.Show();
        }

        public PhoneInstance PhoneInstance { get; set; }

        /// <summary>
        /// if possible try to get connected with a network.
        /// </summary>
        /// <returns></returns>
        public bool TryToGetOnline() {
            var network = Global.Network.GetAvailableNetwork();
            if (network != null && !IsOnline) {
                this.IsOnline = network.ConnectNetwrok(this);
                this.RelatedNetwork = network;
                this.NetwrokId = network.NetworkId;
                return IsOnline;

            } else if (network != null && IsOnline) {
                return true; // already online
            }
            IsOnline = false;
            return IsOnline;

        }


        #region Implementation of IBehaviourRinging

        public bool IsRinging { get; set; }

        public void StartRinging(Phone dialingToPhone) {
            dialingToPhone.DisplayInterface();
            this.IsOnDialing = true;
            dialingToPhone.IsOnDialing = true;
            dialingToPhone.PhoneInstance.StartRinging(this);
            
        }




        public void StopRinging() {
           
        }

        #endregion

        #region Implementation of IFlashingBehaviour

        public bool IsFlashing { get; set; }

        public void StartFlashing() {
            IsFlashing = true;
        }

        public void StopFlashing() {
            IsFlashing = false;
        }

        #endregion

        #region Implementation of INetwork

        public int NetwrokId { get; set; }

        #endregion

        #region Implementation of ISms

        /// <summary>
        /// returns true if send successfully.
        /// </summary>
        public bool SendSms(Phone cellphone) {
            throw new System.NotImplementedException();
        }

        public bool SendSms(long phoneNumber) {
            throw new System.NotImplementedException();
        }

        #endregion

        public long PhoneNumber { get; set; }

        public Phone ConnectedPhone { get; set; }


        public Phone CallingPhone { get; set; }


        /// <summary>
        /// if connected then true
        /// </summary>
        public bool MakeCall(long phoneNumber) {
            bool isSuccefull = MakeCallInSameNetwork(phoneNumber);
            return true;
        }

        /// <summary>
        /// First check if phone is online or in a network then
        /// if it finds the phone in that network then it will try to connect.
        /// if connected then true
        /// </summary>
        public bool MakeCallInSameNetwork(long phoneNumber) {
            // first check if this cell phone is online
            if (IsOnline && !IsOnDialing) {
                var findPhone = RelatedNetwork.FindPhone(phoneNumber: phoneNumber);
                if (findPhone != null) {
                    // that means phone is connected , not switched off

                    // now check if it is on call or not
                    if (findPhone.IsPhoneOnCall == false && 
                        findPhone.PhoneNumber != this.PhoneNumber && 
                        !findPhone.IsOnDialing) {
                        StartRinging(findPhone);

                        return true;

                    }
                }
            }
            return false;
        }

        public void TerminateCall() {
            if (IsPhoneOnCall) {
                IsPhoneOnCall = false;
                ConnectedPhone = null;
                CallingPhone = null;
                StopFlashing();
                StopRinging();
            }
        }


        /// <summary>
        /// Removing from network.
        /// </summary>
        public void SwtichOff() {
            TerminateCall();
            RelatedNetwork.RemovePhone(this);
            RelatedNetwork = null;
            IsOnline = false;
        }

        public LocalNetwork RelatedNetwork { get; set; }



        /// <summary>
        /// is switch on or off
        /// </summary>
        public bool IsOnline { get; set; }

        /// <summary>
        /// Dialing someone or someone dialing
        /// </summary>
        public bool IsOnDialing { get; set; }

        /// <summary>
        /// Is it necessary to flash the phone while ringing
        /// </summary>
        public bool IsFlashingOnWhenRinging { get; set; }



        /// <summary>
        /// true if on call
        /// </summary>
        public bool IsPhoneOnCall { get; set; }
    }
}