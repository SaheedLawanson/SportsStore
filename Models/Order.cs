using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models;

public class Order {
    [BindNever]
    public Int32 OrderID { get; set; }
    
    [BindNever]
    public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

    [Required(ErrorMessage = "Please enter a name")]
    public String? Name { get; set; }

    [Required(ErrorMessage = "Please enter the first address line")]
    public String? Line1 { get; set; }
    public String? Line2 { get; set; }
    public String? Line3 { get; set; }

    [Required(ErrorMessage = "Please enter a city name")]
    public String? City { get; set; }

    [Required(ErrorMessage = "Please enter a state name")]
    public String? State { get; set; }

    public String? Zip { get; set; }

    [Required(ErrorMessage = "Please enter a country name")]
    public String? Country { get; set; }

    public Boolean GiftWrap { get; set; }   

    [BindNever]
    public Boolean Shipped { get; set; }
}