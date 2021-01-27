using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pare
{ 
    public class CreateQuery
    {
        [StringLength(50)]
        public string Name { get; set; }
        public string outCome { get; set; }

        public int  Score{ get; set; }
        public int  index{ get; set; }
        public int  SessionID{ get; set; }
        public int  Enough{ get; set; }


        
    }
}