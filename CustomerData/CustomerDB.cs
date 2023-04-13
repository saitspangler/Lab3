using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// repository of methods for working with Customers table
    /// </summary>
    public static class CustomerDB
    {
        /// <summary>
        /// retrieve all customerIDs
        /// </summary>
        /// <returns>list of customer IDs</returns>
        public static List<int> GetCustomerIDs()
        {
            List<int> custIDs = new List<int>(); // empty list
            using (MMABooksContext db = new MMABooksContext())
            {
                custIDs = db.Customers.
                    Select(c => c.CustomerId).ToList();  
            }
            return custIDs;
        }

        /// <summary>
        /// finds customer with given ID
        /// </summary>
        /// <param name="custID">customer ID to find</param>
        /// <returns>the customer with given ID or null if not found</returns>
        public static Customer FindCustomer(int custID)
        {
            Customer customer = null;
            using(MMABooksContext db = new MMABooksContext())
            {
                //customer = db.Customers.Where(c => c.CustomerId == custID).SingleOrDefault();// works for any property
                customer = db.Customers.Find(custID); // method Find is good for searching by PK value
            }
            return customer;
        }

        /// <summary>
        /// adds a new row to the Customers table
        /// </summary>
        /// <param name="newCust">object that contains new data</param>
        /// <returns>generated identity value</returns>
        public static int AddCustomer(Customer newCust)
        {
            int custID = 0; // new customer id (will be generated)
            if(newCust != null) // if there is a customer to add
            {
                using (MMABooksContext db = new MMABooksContext())
                {
                    db.Customers.Add(newCust); // add object to the collection in the app
                    db.SaveChanges(); // saves changes made to object in the app to the database
                    custID = newCust.CustomerId; // yes, the generated identity value is there!
                }
            }
            return custID;
        }

        /// <summary>
        /// updates customer record with new data
        /// </summary>
        /// <param name="custID">id of the customer to update</param>
        /// <param name="newCustomerData"> new data values for the customer</param>
        /// <returns>true if updated and false if not</returns>
        public static bool UpdateCustomer(int custID, Customer newCustomerData) 
        {
            bool didUpdate = false;
            Customer cust = null;
            if(newCustomerData != null)
            {
                using(MMABooksContext db = new MMABooksContext())
                {
                    cust = db.Customers.Find(custID); // find the customer in current context
                    if(cust != null)
                    {
                        // ready for update
                        cust.Name = newCustomerData.Name;
                        cust.Address = newCustomerData.Address;
                        cust.City = newCustomerData.City;
                        cust.State = newCustomerData.State;
                        cust.ZipCode = newCustomerData.ZipCode;
                        // no need to call Update
                        db.SaveChanges();
                        didUpdate = true;// success
                    }
                }
            }
            return didUpdate;
        }

        /// <summary>
        /// deleted customer with given id
        /// </summary>
        /// <param name="custID">id of customer to delete</param>
        /// <returns>true if deleted and false if not</returns>
        public static bool DeleteCustomer(int custID)
        {
            bool didDelete = false;
            Customer cust = null; // customer to delete
            using(MMABooksContext db = new MMABooksContext()) 
            {
                cust = db.Customers.Find(custID);
                if(cust != null)
                {
                    db.Customers.Remove(cust);
                    db.SaveChanges();
                    didDelete = true;
                }
            }
            return didDelete;
        }

    }
}
