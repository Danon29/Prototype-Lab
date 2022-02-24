using System;
using System.Collections.Generic;
using System.Text;

namespace lab13 {

    interface IClonable {
        Food Copy();
        Food DeepCopy();
    }
}
