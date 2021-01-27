using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pare
{ 
    public class Query
    {
        [StringLength(50)]
        public string Term { get; set; }
        [StringLength(75)]
        public string Location { get; set; }
        public int  SessionID{ get; set; }
        public int  MaxLocations{ get; set; }
        public int  Enough{ get; set; }

        
    }
}