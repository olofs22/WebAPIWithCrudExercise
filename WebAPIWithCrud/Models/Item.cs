using System.ComponentModel.DataAnnotations;

namespace WebAPIWithCrud.Models;
public class Items
{
    [Required, Range(1, 20)]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = "";
    [StringLength (15)]
    public string Description { get; set; } = "";
}
