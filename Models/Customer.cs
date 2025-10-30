using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsConsoleApp.Models;

public class Customer
{
    [Key]
    public int Id { get; set; }
    [Required, StringLength(30)]
    public string Name { get; set; } = string.Empty;
    [Required, StringLength(30)]
    public string Email { get; set; } = string.Empty;
    [Required, StringLength(12)]
    public string Phone { get; set; } = string.Empty;

    public List<Order> Orders { get; set; } = new();

}
