using System;
using System.Linq;
using CellPhone.CellPhonePattern.Interfaces;
using CellPhone.Implementation;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class Phone : IBehaviourRinging, IFlashingBehaviour, INetwork, ISms {

        public Phone(long phoneNumber) {
            if (Global.PhoneNumbers.Any(n => n == phoneNumber)) {
                throw new Exception("you can't create a phone with existing number.");
            }
            TryToGetOnline();
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// if possible try to get connected with a network.
        /// </summary>
        /// <returns></returns>
        public bool TryToGetOnline() {
            var network = Global.Network.GetAvailableNetwork();
            if (network != null) {

                this.IsOnline = network.ConnectNetwrok(this);
                this.RelatedNetwork = network;
                this.NetwrokId = network.NetworkId;
                return IsOnline;

            }
            IsOnline = false;
            return IsOnline;

        }


        #region Implementation of IBehaviourRinging

        public bool IsRinging { get; set; }

        public void StartRinging() {
            throw new System.NotImplementedException();
        }

        public void StopRinging() {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Implementation of IFlashingBehaviour

        public bool IsFlashing { get; set; }

        public void StartFlashing() {
            throw new System.NotImplementedException();
        }

        public void StopFlashing() {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// First check if phone is online or in a network then
        /// if it finds the phone in that network then it will try to connect.
        /// if connected then true
        /// </summary>
        public bool MakeCallInSameNetwork(long phoneNumber) {
            // first check if this cell phone is online
            if (IsOnline) {
                var findPhone = RelatedNetwork.FindPhone(phoneNumber: phoneNumber);
                if (findPhone != null) {
                    // that means phone is connected , not switched off

                    // now check if it is on call or not
                    if (findPhone.IsPhoneOnCall == false) {
                        findPhone.StartRinging();
                    }
                }
            }
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
        /// Is it necessary to flash the phone while ringing
        /// </summary>
        public bool IsFlashingOnWhenRinging { get; set; }

        

        /// <summary>
        /// true if on call
        /// </summary>
        public bool IsPhoneOnCall { get; set; }
    }
}