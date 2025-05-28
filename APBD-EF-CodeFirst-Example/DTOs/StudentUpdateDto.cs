using System.ComponentModel.DataAnnotations;

namespace APBD_EF_CodeFirst_Example.DTOs;

public class StudentUpdateDto
{
    [MaxLength(50)] 
    [Required] 
    public string FirstName { get; set; } = null!;
    
    [MaxLength(50)]
    [Required]
    public string LastName { get; set; } = null!;
    
    [Required]
    public int Age { get; set; }
    
    public float? EntranceExamScore { get; set; }
}