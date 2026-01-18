using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class OrderStatus
    {
        public enum Status
        {
            Geplaatst = 1,
            InBehandeling = 2,
            Klaar = 3,
            Geserveerd = 4,
        }
    }
}
