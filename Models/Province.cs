using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProvinceCity.Models;

public class Province
{
    // [Key]
    // [MaxLength(30)]
    // [Display(Name = "Province Code")]
    // public string? ProvinceCode { get; set; }

    // // [Column("Province")]
    // [Display(Name = "Province Name")]
    // public string? ProvinceName { get; set; }

    // [Display(Name = "Cities")]
    // public string? Citiess { get; set; }



     [Key]
    [Required]
    [MaxLength(2)]
    public required string ProvinceCode { get; set; }

    [Required]
    [MaxLength(100)]
    public required string ProvinceName { get; set; }
    
     
    // Navigation property to represent the one-to-many relationship
     public ICollection<City> Cities { get; set; }

}
