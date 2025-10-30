using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarsConsoleApp.Models;

public class Car
{
    [Key]
    public int Id { get; set; }
    [Required, StringLength(30)]
    public string Brand { get; set; } = string.Empty;
    [Required, StringLength(30)]
    public string Model { get; set; } = string.Empty;
    [Range(1800, 2030)]
    public int Year { get; set; }
    [Required, StringLength(8)]
    public string LicensePlate { get; set; } = string.Empty;
    [StringLength(30)]
    public string Color { get; set; } = string.Empty;

    public List<Order> Orders { get; set; } = new();

}
