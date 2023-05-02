using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDatas
{
    public class PackagesManager
    {
        ///summary
        ///Repository of methods to work with the Packages table of the Travel Experts Database
        ///summary
        ///

        public static List<Package> GetAllPackages()
        {
            TravelExpertsContext db = new TravelExpertsContext();
            List<Package> packages = db.Packages.ToList();
            return packages;
        }

        public static Package GetPackageById(TravelExpertsContext db, int packageId)
        {
            Package package = db.Packages.Find(packageId);
            return package;
        }

        public static void AddPackage(Package package)
        {
            TravelExpertsContext db = new TravelExpertsContext();
            db.Packages.Add(package);
            db.SaveChanges();
        }

        public static void UpdatePackage(int packageId, Package newPackage)
        {
            using (var db = new TravelExpertsContext())
            {
                // Retrieve the Package object from the database
                var package = db.Packages.Find(packageId);

                // Update the Package object with the new values
                package.PkgName = newPackage.PkgName;
                package.PkgDesc = newPackage.PkgDesc;
                package.PkgStartDate = newPackage.PkgStartDate;
                package.PkgEndDate = newPackage.PkgEndDate;
                package.PkgBasePrice = newPackage.PkgBasePrice;
                package.PkgAgencyCommission = newPackage.PkgAgencyCommission;

                // Save the changes to the database
                db.SaveChanges();
            }
        }

        public static void DeletePackage(TravelExpertsContext db, Package package)
        {
            db.Packages.Remove(package);
            db.SaveChanges();
        }
    }
}
