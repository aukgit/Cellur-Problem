using System.Collections.Generic;

namespace CellPhone.CellPhonePattern.BluePrints {
    public class GlobalNetwork {
        public List<LocalNetwork> Networks { get; set; }

        public bool ConnectToLocalNetwork(Phone phone) {
            throw new System.NotImplementedException();
        }

        public bool ConnectToLocalNetwork(Phone phone, LocalNetwork localNetwrok) {
            throw new System.NotImplementedException();
        }
    }
}
