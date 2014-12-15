namespace CellPhone.CellPhonePattern.Interfaces {
    public interface IFlashingBehaviour {
    
        bool IsFlashing { 
            get;
            set;
        }

        void StartFlashing();

        void StopFlashing();
    }
}
