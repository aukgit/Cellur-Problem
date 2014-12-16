using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            IsOnline = true;
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
            if (IsOnDialing) {
                throw new Exception("You are already dialing to a number");
            }

            if (dialingToPhone.IsOnDialing) {
                throw new Exception("Number you are trying to dial is busy by someone else's call");
            }
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
            if (IsOnDialing) {
                MessageBox.Show("Sorry you are already making a call, you can't make two call simultaniously..");
                return false;
            }
            if (IsOnline && !IsOnDialing) {
                foreach (var network in Global.Network.Networks) {
                    var findPhone = network.FindPhone(phoneNumber: phoneNumber);
                    if (findPhone != null) {
                        return DialPhone(findPhone);
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// First check if phone is online or in a network then
        /// if it finds the phone in that network then it will try to connect.
        /// if connected then true
        /// </summary>
        public bool MakeCallInSameNetwork(long phoneNumber) {
            if (IsOnDialing) {
                MessageBox.Show("Sorry you are already making a call, you can't make two call simultaniously..");
                return false;
            }
            // first check if this cell phone is online
            if (IsOnline && !IsOnDialing) {
                var findPhone = RelatedNetwork.FindPhone(phoneNumber: phoneNumber);
                return DialPhone(findPhone);
            }
            return false;
        }

        public bool DialPhone(Phone findPhone) {
            if (findPhone != null) {
                // that means phone is connected , not switched off

                if (findPhone.PhoneNumber == this.PhoneNumber) {
                    MessageBox.Show("Sorry you can't dial your own number.");

                    return false;
                }
                // now check if it is on call or not
                if (findPhone.IsPhoneOnCall) {
                    MessageBox.Show("Dialing number is already on call with someone.");

                    return false;
                }
                if (findPhone.IsPhoneOnCall == false &&
                    findPhone.PhoneNumber != this.PhoneNumber &&
                    !findPhone.IsOnDialing) {
                    StartRinging(findPhone);

                    return true;

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