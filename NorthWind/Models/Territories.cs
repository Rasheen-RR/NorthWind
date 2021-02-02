using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthWind.Models
{
    class Territories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int territoryID { get; set; }
        public int regionID { get; set; }
        public String territoryDescription { get; set; }
        
        [ForeignKey("regionID")]
        public Region region { get; set; }

    }
}
