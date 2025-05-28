using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_EF_CodeFirst_Example.Models;

[Table("GroupAssignment")]
[PrimaryKey(nameof(GroupId), nameof(StudentId))]
public class GroupAssignment
{
    [Column("Group_Id")]
    public int GroupId { get; set; } // => int not null, name: Group_Id
    
    [Column("Student_Id")] 
    public int StudentId { get; set; } // => int not null, name: Student_Id

    [ForeignKey(nameof(StudentId))]
    public virtual Student Student { get; set; } = null!; // => navigation property. Needed to map relationships between tables.
    
    [ForeignKey(nameof(GroupId))]
    public virtual Group Group { get; set; } = null!; // => navigation property. Needed to map relationships between tables.
}