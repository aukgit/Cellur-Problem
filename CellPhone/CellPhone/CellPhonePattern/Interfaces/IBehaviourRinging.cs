namespace CellPhone.CellPhonePattern.Interfaces {
    public interface IBehaviourRinging {
        bool IsRinging {
            get;
            set;
        }
    
        void StartRinging();

        void StopRinging();
    }
}
