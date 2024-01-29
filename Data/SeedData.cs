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

  


       public static List<Province> GetProvinces() {
        return new List<Province>() {
            new Province { ProvinceCode = "QC", ProvinceName = "Quebec" },
            new Province { ProvinceCode = "ON", ProvinceName = "Ontario" },
            new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
            new Province { ProvinceCode = "AB", ProvinceName = "Alberta" },
        };
    }
 };
    