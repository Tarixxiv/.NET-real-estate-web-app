using System.ComponentModel.DataAnnotations;

namespace RealEstateWebApp.Models;



public class ClientMessage
{
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [Phone]
    public string TelNum { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string Content { get; set; }
    [Required]
    public string DayOfWeek { get; set; }
    [Required]
    [Range(1,1)]
    public bool AllowDataProcessing { get; set; }
}