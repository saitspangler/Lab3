using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class InvoiceDTO
    {        
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }        
        public DateTime InvoiceDate { get; set; }        
        public decimal InvoiceTotal { get; set; }
    }
}
