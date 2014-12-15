using CellPhone.CellPhonePattern.Interfaces;

namespace CellPhone.CellPhonePattern.BluePrints
{
    public class Phone : IBehaviourRinging, IFlashingBehaviour, INetwork, ISms
    {
        #region Implementation of IBehaviourRinging

        public int IsRinging
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

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

        public bool IsFlashing
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

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

        public int NetwrokId
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

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

        public long PhoneNumber {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public Phone ConnectedPhone { get; set; }
        

        public Phone CallingPhone { get; set; }

        public int IsReceivedFrom {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// if connected then true
        /// </summary>
        public bool MakeCall(long phoneNumber) {
            throw new System.NotImplementedException();
        }

        public bool TerminateCall() {
            throw new System.NotImplementedException();
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
    }
}