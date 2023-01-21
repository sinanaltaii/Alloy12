using System.ComponentModel.DataAnnotations;

namespace Alloy12.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
