using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthWind.Models
{
    class Shippers
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int shipperID { get; set; }
        public String companyName { get; set; }
        public String phone { get; set; }


    }
}
