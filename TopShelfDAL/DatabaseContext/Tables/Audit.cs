using System;
using System.Collections.Generic;
using System.Text;

namespace TopShelfDAL.DatabaseContext.Tables
{
    public class Audit
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
    }
}
