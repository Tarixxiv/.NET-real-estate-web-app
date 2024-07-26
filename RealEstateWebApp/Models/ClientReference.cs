using System.ComponentModel.DataAnnotations;

namespace RealEstateWebApp.Models;

public class ClientReference
{
    public int Id { get; set; }
    [Required]
    public string Author { get; set; }
    [Required]
    public string Content { get; set; }
    
}