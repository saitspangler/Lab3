using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechSupportData
{
    public partial class Product
    {

        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Range(0, 18)]
        public decimal Version { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
