using CellPhone.CellPhonePattern.Interfaces;
using CellPhone.Implementation;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class Phone : IBehaviourRinging, IFlashingBehaviour, INetwork, ISms {

        public Phone() {
            TryToGetOnline();
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

        public LocalNetwork RelatedNetwork { get; set; }



        /// <summary>
        /// is switch on or off
        /// </summary>
        public bool IsOnline { get; set; }

        public bool IsFlashingOnWhenRinging { get; set; }

        /// <summary>
        /// true if on call
        /// </summary>
        public bool IsPhoneOnCall { get; set; }
    }
}