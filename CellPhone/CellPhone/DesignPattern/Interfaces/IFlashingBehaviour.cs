namespace CellPhone.DesignPattern.Interfaces {
    public interface IFlashingBehaviour {
    
        bool IsFlashing { 
            get;
            set;
        }

        void StartFlashing();

        void StopFlashing();
    }
}
