using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models.ViewModels;

public class LoginModel {
    [Required]
    public String? Name { get; set; }
    
    [Required]
    public String? Password { get; set; }

    public String ReturnUrl { get; set; } = "/";
}