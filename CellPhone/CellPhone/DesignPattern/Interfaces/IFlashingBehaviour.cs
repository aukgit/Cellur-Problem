namespace CellPhone.DesignPattern.Interfaces {
    public interface IFlashingBehaviour {
    
        bool IsFlashing {
            set;
        }

        void StartFlashing();

        void StopFlashing();
    }
}
