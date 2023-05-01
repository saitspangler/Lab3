using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{        
    ///summary
    ///Repository of methods to work with the Packages table of the Travel Experts Database
    ///summary
    
    public class PackagesManager
    {
        /// <summary>
        /// Method to get all packages from the database
        /// </summary>
        /// <param>name="db"</param>
        /// <returns>all packages from database</returns>
        public static List<Package> GetAllPackages(TravelExpertsContext db)
        {
            List<Package> packages = db.Packages.ToList();
            return packages;
        }

        /// <summary>
        /// Returns the package with the given package id
        /// </summary>
        /// <param name="db"></param>
        /// <param name="packageId"></param>
        /// <returns>the given package</returns>
        public static Package GetPackage(TravelExpertsContext db, int packageId)
        {
            Package package = db.Packages.Find(packageId);
            return package;
        }
        /// <summary>
        /// Adds a package to the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="package"></param>
        /// <returns>updated database with package added</returns>
        public static void AddPackage(TravelExpertsContext db, Package package)
        {
            db.Packages.Add(package);
            db.SaveChanges();
        }
        /// <summary>
        /// Updates a package in the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="oldPackage"></param>
        /// <param name="newPackage"></param>
        public static void UpdatePackage(TravelExpertsContext db, Package oldPackage, Package newPackage)
        {
            db.Entry(oldPackage).CurrentValues.SetValues(newPackage);
            db.SaveChanges();
        }

        /// <summary>
        /// Deletes a package from the database
        /// </summary>
        /// <param name="db"></param>
        /// <param name="package"></param>
        public static void DeletePackage(TravelExpertsContext db, Package package)
        {
            db.Packages.Remove(package);
            db.SaveChanges();
        }
    }
}
