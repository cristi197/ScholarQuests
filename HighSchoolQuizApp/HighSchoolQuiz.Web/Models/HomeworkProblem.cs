namespace HighSchoolQuiz.Web.Models;

public class HomeworkProblem
{
    public int Id { get; set; }

    public int HomeworkId { get; set; }
    public Homework Homework { get; set; } = default!;

    public int ProblemId { get; set; }
    public Problem Problem { get; set; } = default!;
}
