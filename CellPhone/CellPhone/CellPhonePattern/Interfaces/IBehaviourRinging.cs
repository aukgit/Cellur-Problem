namespace CellPhone.CellPhonePattern.Interfaces {
    public interface IBehaviourRinging {
        int IsRinging {
            get;
            set;
        }
    
        void StartRinging();

        void StopRinging();
    }
}
