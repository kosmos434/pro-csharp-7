namespace AutoLotDAL.Models
{
    using AutoLotDAL.Models.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    // so even though this is called "Car" it will map to Inventory table
    // oops now its called Inventory again
    [Table("Inventory")]
    public partial class Inventory : EntityBase
    {
        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string PetName { get; set; }

        // this is a foreign key to orders
        public virtual ICollection<Order> Orders { get; set; } 
            = new HashSet<Order>();
    }
}
