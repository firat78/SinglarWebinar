namespace SinglarWebinar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int ID { get; set; }

        [Required]
        [StringLength(300)]
        public string ProductName { get; set; }

        public decimal? Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
