using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellPhone {
    public interface IFlashingBehaviour {
        bool IsFlashing {
            get;
            set;
        }
    }
}
