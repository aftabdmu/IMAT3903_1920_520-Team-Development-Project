using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsAKAppts
    {

        public clsAKAppts()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int ApptNo { get; internal set; }
        public DateTime ApptDate { get; internal set; }
        public int ApptTime { get; internal set; }
        public string ApptReason { get; internal set; }
    }

}

