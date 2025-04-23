using HighSchoolQuiz.Web.Models.Enums;

namespace HighSchoolQuiz.Web.Models;

public class Problem
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public int GradeLevel { get; set; } // 9, 10, 11 etc
    public DifficultyLevel Difficulty { get; set; } = DifficultyLevel.Easy;
    public string Category { get; set; } = default!;
    public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int CreatedById { get; set; }
    public User CreatedBy { get; set; } = default!;

    public ICollection<ProblemTest>? Tests { get; set; }
    public ICollection<HomeworkProblem>? HomeworkProblems { get; set; }
    public ICollection<Solution>? Solutions { get; set; }
}
