using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Data.SqlClient;
using CowabungaBankingLIB;

namespace CowabungaBankingLIB
{
    public class Branch_Details
    {
        public class BranchDetails
        {
            public string brName { get; set; }
            public string brCity { get; set; }
            public string brEmail { get; set; }
            public int brContactNo { get; set; }
            public bool brOpenStatus { get; set; }
        }

    }
}
