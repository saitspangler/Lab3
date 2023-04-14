using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechSupportData
{
    public partial class Customer
    {

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Address { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string State { get; set; } = null!;
        [StringLength(15)]
        [Unicode(false)]
        public string ZipCode { get; set; } = null!;

        [StringLength(20)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;

        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

    }
}
