using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_EF_CodeFirst_Example.Models;

[Table("Student")]
public class Student
{
    [Key]
    public int Id { get; set; } // => int primary key with identity (auto increment)
    
    [MaxLength(50)]
    public string FirstName { get; set; } = null!; // => varchar(50) not null
    
    [MaxLength(50)]
    public string LastName { get; set; } = null!; // => varchar(50) not null
    
    public int Age { get; set; } // => int not null
    
    public float? EntranceExamScore { get; set; } // float nullable
    
    public virtual ICollection<GroupAssignment> GroupAssignments { get; set; } = null!; // => navigation property. Needed to map relationships between tables.
}