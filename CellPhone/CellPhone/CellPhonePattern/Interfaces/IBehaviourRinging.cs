using CellPhone.CellPhonePattern.BluePrints;

namespace CellPhone.CellPhonePattern.Interfaces {
    public interface IBehaviourRinging {
        bool IsRinging {
            get;
            set;
        }

        bool StartRinging(Phone dialingToPhone);

        void StopRinging();
    }
}
