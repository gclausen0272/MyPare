using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pare
{ 
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(75)]
        public string Description { get; set; }
        public int  SessionID{ get; set; }
        public int  Score{ get; set; }
        [StringLength(2083)]
        public string Url {get; set;}
        [StringLength(2083)]
        public string ImageUrl {get; set;}
        public string menuUrl {get; set;}    
    }
}