namespace APBD_EF_CodeFirst_Example.DTOs;

public class StudentGetDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
    public float? EntranceExamScore { get; set; }
    public ICollection<StudentGetDtoGroup> Groups { get; set; } = null!;
}

public class StudentGetDtoGroup
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}