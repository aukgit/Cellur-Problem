namespace CellPhone.DesignPattern.Interfaces {
    public interface IBehaviourRinging {
        int IsRinging {
            get;
            set;
        }
    
        void StartRinging();

        void StopRinging();
    }
}
