using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                     Id = 1,
                     Name = "Court House Green",
                     Description = "Austin Drive, Coventry, England",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 1,
                             Name = "Post Code:",
                             Description = "CV6 7NS" },
                          new PointOfInterestDto() {
                             Id = 2,
                             Name = "Telephone",
                             Description = "024 7666 4477" },
                     }
                },
                new CityDto()
                {
                     Id = 2,
                     Name = "London Colney",
                     Description = "Colney Fields Shopping Park, St. Albans, England",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 3,
                             Name = "Post Code:",
                             Description = "AL2 1AB" },
                          new PointOfInterestDto() {
                             Id = 4,
                             Name = "Telephone",
                             Description = "01707 429220" },
                     }
                },
                new CityDto()
                {
                     Id = 3,
                     Name = "Nuneaton",
                     Description = "Vicarage Street, Nuneaton, England",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 5,
                             Name = "Post Code:",
                             Description = "CV11 4XS" },
                          new PointOfInterestDto() {
                             Id = 6,
                             Name = "Telephone",
                             Description = "02476 375880" },
                     }
                },
                new CityDto()
                {
                     Id = 4,
                     Name = "Milton Keynes",
                     Description = "799 Witan Gate, Milton Keynes, England",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 7,
                             Name = "Post Code:",
                             Description = "MK9 2FW" },
                          new PointOfInterestDto() {
                             Id = 8,
                             Name = "Telephone",
                             Description = "01908 674154" },
                     }
                },
                new CityDto()
                {
                     Id = 5,
                     Name = "Leicester North",
                     Description = "501 Melton Road, Leicester, England",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 9,
                             Name = "Post Code:",
                             Description = "LE4 7SJ" },
                          new PointOfInterestDto() {
                             Id = 10,
                             Name = "Telephone",
                             Description = "0116 2018180" },
                     }
                },
                new CityDto()
                {
                     Id = 6,
                     Name = "Southampton Portswood",
                     Description = "224 Portswood Road, Southampton, England",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 11,
                             Name = "Post Code:",
                             Description = "SO17 2LB" },
                          new PointOfInterestDto() {
                             Id = 12,
                             Name = "Telephone",
                             Description = "023 81242821" },
                     }
                },
            };

        }
    }
}
