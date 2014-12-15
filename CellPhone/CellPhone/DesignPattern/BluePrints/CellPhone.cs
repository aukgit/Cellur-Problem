using CellPhone.DesignPattern.Interfaces;

namespace CellPhone.DesignPattern.BluePrints
{
    public class CellPhone : IBehaviourRinging, CellPhone.DesignPattern.Interfaces.IFlashingBehaviour, CellPhone.DesignPattern.Interfaces.INetwork
    {
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

        #region IFlashingBehaviour Members

        public bool IsFlashing {
            get {
                throw new System.NotImplementedException();
            }
            set {
                throw new System.NotImplementedException();
            }
        }

        public void StartFlashing() {
            throw new System.NotImplementedException();
        }

        public void StopFlashing() {
            throw new System.NotImplementedException();
        }

        #endregion

        #region INetwork Members

        public int NetwrokID {
            get {
                throw new System.NotImplementedException();
            }
            set {
                throw new System.NotImplementedException();
            }
        }

        #endregion

        public int PhoneNumber {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public CellPhone ConnectedPhone {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        public CellPhone CallingPhone {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
    }
}