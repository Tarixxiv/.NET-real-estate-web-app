using System.ComponentModel.DataAnnotations;

namespace RealEstateWebApp.Models;

public class ReportedOffer
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
    public string EstateType { get; set; }
    [Required]
    public string TransactionType { get; set; }
    [Required]
    public string Localisation { get; set; }
    [Required]
    public string Area { get; set; }
    [Required]
    public string Price { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string DayOfWeek { get; set; }
    [Required]
    [Range(1,1)]
    public bool AllowDataProcessing { get; set; }
    
}