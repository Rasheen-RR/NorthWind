using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthWind.Models
{
    class Suppliers
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int supplierID { get; set; }
        public String companyName { get; set; }
        public String contactName { get; set; }
        public String contactTitle { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String region { get; set; }
        public String postalCode { get; set; }
        public String country { get; set; }
        public String fax { get; set; }
        public String homepage { get; set; }

    }
}
