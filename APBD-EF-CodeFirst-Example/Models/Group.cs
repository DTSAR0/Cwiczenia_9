using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_EF_CodeFirst_Example.Models;

[Table("Group")]
public class Group
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(10)] 
    public string Name { get; set; } = null!; // => varchar(10) not null
    
    public virtual ICollection<GroupAssignment> GroupAssignments { get; set; } = null!; // => navigation property. Needed to map relationships between tables.
}