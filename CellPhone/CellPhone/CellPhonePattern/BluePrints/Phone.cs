using CellPhone.CellPhonePattern.Interfaces;

namespace CellPhone.CellPhonePattern.BluePrints
{
    public class Phone : IBehaviourRinging, IFlashingBehaviour, INetwork, ISms
    {
        #region Implementation of IBehaviourRinging

        public bool IsRinging { get; set; }

        public void StartRinging()
        {
            throw new System.NotImplementedException();
        }

        public void StopRinging()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Implementation of IFlashingBehaviour

        public bool IsFlashing { get; set; }

        public void StartFlashing()
        {
            throw new System.NotImplementedException();
        }

        public void StopFlashing()
        {
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
        public bool SendSms(Phone cellphone)
        {
            throw new System.NotImplementedException();
        }

        public bool SendSms(long phoneNumber)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        public long PhoneNumber { get; set; }

        public Phone ConnectedPhone { get; set; }
        

        public Phone CallingPhone { get; set; }

        public bool IsReceivedFrom { get; set; }

        /// <summary>
        /// if connected then true
        /// </summary>
        public bool MakeCall(long phoneNumber) {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// if connected then true
        /// </summary>
        public bool MakeCallInSameNetwork(long phoneNumber) {
            throw new System.NotImplementedException();
        }

        public void TerminateCall() {
            if (IsPhoneOnCall)
            {
                IsPhoneOnCall = false;
                IsReceivedFrom = false;
                IsRinging = false;
                ConnectedPhone = null;
            }
        }

        public LocalNetwork RelatedNetwork {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// is switch on or off
        /// </summary>
        public bool IsOnline {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public bool IsFlashingOnWhenRinging {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// true if on call
        /// </summary>
        public bool IsPhoneOnCall {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
    }
}