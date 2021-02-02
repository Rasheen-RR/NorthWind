using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthWind.Models
{
    class Products
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productID { get; set; }
        public int categoryID { get; set; }
        public int supplierID { get; set; }
        public String productName { get; set; }
        [ForeignKey("categoryID")]
        public Categories categories { get; set; }
        [ForeignKey("supplierID")]
        public Suppliers suppliers { get; set; }
        public int quantityPerLabel { get; set; }
        public float unitPrice { get; set; }
        public int unitsInStock { get; set; }
        public int unitsOnOrder { get; set; }
        public int recorderLevel { get; set; }
        public Boolean discontinued { get; set; }

    }
}
