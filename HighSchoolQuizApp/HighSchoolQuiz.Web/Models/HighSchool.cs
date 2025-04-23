namespace HighSchoolQuiz.Web.Models;

public class HighSchool
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string City { get; set; } = default!;
    public string County { get; set; } = default!;
    public string? Address { get; set; }
    public int? FoundedYear { get; set; }

    public ICollection<Class>? Classes { get; set; }
    public ICollection<User>? Teachers { get; set; }
}

