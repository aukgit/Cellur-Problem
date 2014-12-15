using CellPhone.CellPhonePattern.BluePrints;

namespace CellPhone.CellPhonePattern.Interfaces {
    public interface ISms {


        /// <summary>
        /// returns true if send successfully.
        /// </summary>
        bool SendSms(Phone cellphone);

        bool SendSms(long phoneNumber);
    }
}
