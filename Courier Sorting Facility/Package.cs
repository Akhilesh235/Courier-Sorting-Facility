using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Sorting_Facility
{
    class Package
    {
        public string Receivername (string Rname)
        {
            string ReceiverName = Rname;
            ReceiverCounter++;
            return ReceiverName;
        }

        public int TrackingID (int ID)
        {
            int trackingID = ID;
            return trackingID;
        }

        public static int ReceiverCounter;
        public static int RemoverCounter;
    }
}
