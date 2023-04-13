using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    // Product class without navigation property
    public class ProductDTO
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }       
        public decimal UnitPrice { get; set; }
        public int OnHandQuantity { get; set; }
    }
}
