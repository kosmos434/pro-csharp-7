namespace AutoLotDAL.Models
{
    using AutoLotDAL.Models.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer : EntityBase
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        [NotMapped]
        public string FullName => FirstName + " " + LastName;
    }
}
