namespace HighSchoolQuiz.Web.Models;

public class ProblemTest
{
    public int Id { get; set; }
    public string Input { get; set; } = default!;
    public string Output { get; set; } = default!;
    public bool IsPublic { get; set; }

    public int ProblemId { get; set; }
    public Problem Problem { get; set; } = default!;
}
