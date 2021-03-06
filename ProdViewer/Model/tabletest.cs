namespace ProdViewer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tabletest")]
    public partial class tabletest
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(150)]
        public string Info { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacture { get; set; }
    }
}
