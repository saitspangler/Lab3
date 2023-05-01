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
            TravelExpertsContext context = new TravelExpertsContext();
            List<Package> packages = context.Packages.ToList();
            return packages;
        }

        public static Package GetPackageById(int packageId)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            Package package = context.Packages.Find(packageId);
            return package;
        }

        public static void AddPackage(Package package)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Packages.Add(package);
            context.SaveChanges();
        }

        public static void UpdatePackage(Package oldPackage, Package newPackage)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Entry(oldPackage).CurrentValues.SetValues(newPackage);
            context.SaveChanges();
        }

        public static void DeletePackage(Package package)
        {
            TravelExpertsContext context = new TravelExpertsContext();
            context.Packages.Remove(package);
            context.SaveChanges();
        }
    }
}
