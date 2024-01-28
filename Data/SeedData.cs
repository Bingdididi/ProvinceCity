using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProvinceCity.Models;

namespace ProvinceCity.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    
        public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Victoria",
                Population = 85792,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Kelowna",
                Population =132084,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Toronto",
                Population = 1336000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 5,
                CityName = "Ottawa",
                Population = 981280,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 6,
                CityName = "Mississauga",
                Population = 100418,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 7,
                CityName = "Montreal",
                Population = 2930000,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 8,
                CityName = "Quebec City",
                Population = 721599,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 9,
                CityName = "Laval",
                Population = 994837,
                ProvinceCode = "QC"
            },
        };

        return cities;
    }

    // public static List<Province> GetProvinces() {
    //     List<Province> provinces = new List<Province>() {
    //         new Province() {    // 1
    //             ProvinceCode="BC",
    //             ProvinceName="British Columbia ",
    //             Citiess="BC",
    //         },
    //         new Province() {    //2
    //             ProvinceCode="ON",
    //             ProvinceName="Ontario",
    //             Citiess="CA",
    //         },
    //         new Province() {    // 3
    //             ProvinceCode="QC",
    //             ProvinceName="Quebec",
    //             Citiess="AB",
    //         },
    //     };

    //     return provinces;
    // }


       public static List<Province> GetProvinces() {
        return new List<Province>() {
            // new Province { ProvinceCode = "BC", ProvinceName = "British Columbia", Cities = new List<City>() {
            //     new City { CityId = 1, CityName = "Vancouver", Population = 675218, ProvinceCode = "BC" },
            //     new City { CityId = 2, CityName = "Victoria", Population = 85792, ProvinceCode = "BC" },
            //     new City { CityId = 3, CityName = "Kelowna", Population = 132084, ProvinceCode = "BC" }
            // } },
            // new Province { ProvinceCode = "AB", ProvinceName = "Alberta", Cities = new List<City>() {
            //     new City { CityId = 4, CityName = "Calgary", Population = 1239220, ProvinceCode = "AB" },
            //     new City { CityId = 5, CityName = "Edmonton", Population = 972223, ProvinceCode = "AB" },
            //     new City { CityId = 6, CityName = "Red Deer", Population = 100418, ProvinceCode = "AB" }
            // } },
            // new Province { ProvinceCode = "ON", ProvinceName = "Ontario", Cities    = new List<City>() {
            //     new City { CityId = 7, CityName = "Toronto", Population = 1336000, ProvinceCode = "ON" },
            //     new City { CityId = 8, CityName = "Ottawa", Population = 981280, ProvinceCode = "ON" },
            //     new City { CityId = 9, CityName = "Mississauga", Population = 100418, ProvinceCode = "ON" }
            // } },

            new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
            new Province { ProvinceCode = "AB", ProvinceName = "Alberta" },
        };
    }
 };
    