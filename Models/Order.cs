using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsConsoleApp.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(Car))]
    public int CarId { get; set; }
    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    [StringLength(300)]
    public string Description { get; set; }
    [Range(0, 999999)]
    public decimal TotalCost { get; set; }
    public Car Car { get; set; }
    public Customer Customer { get; set; }
}
