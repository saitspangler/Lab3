using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// repository of methods for working  with Invoices table
    /// </summary>
    public static class InvoiceDB
    {
        /// <summary>
        /// get invoices of given customer as lightweight DTO objcets
        /// </summary>
        /// <param name="custID">customer ID</param>
        /// <returns>list of InvoiceDTO objects or empty list</returns>
        public static List<InvoiceDTO> GetCustomerInvoices(int custID)
        {
            List<InvoiceDTO> invoices;
            using(MMABooksContext db = new MMABooksContext())
            {
                // method based LINQ (Language Integrated Queries)
                invoices = db.Invoices.Where(i => i.CustomerId == custID).
                    OrderBy(i => i.InvoiceDate).
                    ThenByDescending(i => i.InvoiceTotal).
                    Select(i => new InvoiceDTO 
                    { 
                        InvoiceId = i.InvoiceId,
                        CustomerId = i.CustomerId, 
                        InvoiceDate = i.InvoiceDate,
                        InvoiceTotal = i.InvoiceTotal
                    }).ToList();
            }
            if(invoices == null) //  if no invoices
                invoices = new List<InvoiceDTO>(); // make it empty list
            return invoices;
        }
    }
}
