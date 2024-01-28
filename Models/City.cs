using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProvinceCity.Models;

public class City
{
    public int CityId { get; set; }

    [Display(Name = "City")]
    public string? CityName { get; set; }
    public int Population { get; set; }

    [Required]
    public string? ProvinceCode { get; set; }
    

    [ForeignKey("ProvinceCode")]
    public Province? Province { get; set; }

// ForeignKey attribute to indicate that ProvinceCode is the foreign key
    // [Required]
    // [ForeignKey("Province")]
    // public required string ProvinceCode { get; set; }

    // // Navigation property to represent the many-to-one relationship
    // public  Province Province { get; set; }


}
