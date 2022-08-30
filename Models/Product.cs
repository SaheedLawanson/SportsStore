using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models;
public class Product {
    public Int64? ProductID { get; set; }
    
    [Required(ErrorMessage="Please enter a product name")]
    public String Name { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Please enter a description")]
    public String Description { get; set; } = String.Empty;
    
    [Required]
    [Range(0.01, Double.MaxValue, ErrorMessage = "Please enter a positive price")]
    [Column(TypeName="decimal(8, 2)")]
    public Decimal Price { get; set; }

    [Required(ErrorMessage = "Please specify a category")]
    public String Category { get; set; } = String.Empty;
}