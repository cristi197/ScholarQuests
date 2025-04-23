namespace HighSchoolQuiz.Web.Models;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; } = default!; // 9A, 10B etc
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public int HighSchoolId { get; set; }
    public HighSchool HighSchool { get; set; } = default!;

    public ICollection<User>? Students { get; set; }
    public ICollection<Homework>? Homeworks { get; set; }
}
