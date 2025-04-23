namespace HighSchoolQuiz.Web.Models;

public class Homework
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public int TeacherId { get; set; }
    public User Teacher { get; set; } = null!;

    public int ClassId { get; set; }
    public Class Class { get; set; } = null!;

    public ICollection<HomeworkProblem>? HomeworkProblems { get; set; }
}
