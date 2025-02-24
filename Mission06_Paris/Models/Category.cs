using System.ComponentModel.DataAnnotations;
namespace Mission06_Paris.Models;

public class Category
{
    [Required]
    public int CategoryId { get; set; } 
    
    [Required]
    public string CategoryName { get; set; } 
}