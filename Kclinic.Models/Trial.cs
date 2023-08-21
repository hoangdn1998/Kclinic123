
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kclinic.Models;
public class Trial
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    
    public string Email { get; set; }
    public string Field { get; set; }
    public int Phone { get; set; }
    public string Message { get; set; }
}
