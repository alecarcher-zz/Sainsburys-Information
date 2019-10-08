using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
                new City()
                {
                     Name = "Court House Green",
                     Description = "Austin Drive, Coventry, England",
                     PointsOfInterest = new List<PointOfInterest>()
                     {
                         new PointOfInterest() {
                             Name = "Post Code:",
                             Description = "CV6 7NS" },
                          new PointOfInterest() {
                             Name = "Telephone",
                             Description = "024 7666 4477" },
                     }
                },
                new City()
                {
                     Name = "London Colney",
                     Description = "Colney Fields Shopping Park, St. Albans, England",
                     PointsOfInterest = new List<PointOfInterest>()
                     {
                         new PointOfInterest() {
                             Name = "Post Code:",
                             Description = "AL2 1AB" },
                          new PointOfInterest() {
                             Name = "Telephone",
                             Description = "01707 429220" },
                     }
                },
                new City()
                {
                     Name = "Nuneaton",
                     Description = "Vicarage Street, Nuneaton, England",
                     PointsOfInterest = new List<PointOfInterest>()
                     {
                         new PointOfInterest() {
                             Name = "Post Code:",
                             Description = "CV11 4XS" },
                          new PointOfInterest() {
                             Name = "Telephone",
                             Description = "02476 375880" },
                     }
                },
                new City()
                {
                     Name = "Milton Keynes",
                     Description = "799 Witan Gate, Milton Keynes, England",
                     PointsOfInterest = new List<PointOfInterest>()
                     {
                         new PointOfInterest() {
                             Name = "Post Code:",
                             Description = "MK9 2FW" },
                          new PointOfInterest() {
                             Name = "Telephone",
                             Description = "01908 674154" },
                     }
                },
                new City()
                {
                     Name = "Leicester North",
                     Description = "501 Melton Road, Leicester, England",
                     PointsOfInterest = new List<PointOfInterest>()
                     {
                         new PointOfInterest() {
                             Name = "Post Code:",
                             Description = "LE4 7SJ" },
                          new PointOfInterest() {
                             Name = "Telephone",
                             Description = "0116 2018180" },
                     }
                },
                new City()
                {
                     Name = "Southampton Portswood",
                     Description = "224 Portswood Road, Southampton, England",
                     PointsOfInterest = new List<PointOfInterest>()
                     {
                         new PointOfInterest() {
                             Name = "Post Code:",
                             Description = "SO17 2LB" },
                          new PointOfInterest() {
                             Name = "Telephone",
                             Description = "023 81242821" },
                     }
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
