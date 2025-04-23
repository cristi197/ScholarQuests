namespace HighSchoolQuiz.Web.Models;

public class Solution
{
    public int Id { get; set; }
    public int ProblemId { get; set; }
    public Problem Problem { get; set; } = default!;

    public int StudentId { get; set; }
    public User Student { get; set; } = default!;

    public string Code { get; set; } = default!;
    public string Language { get; set; } = "C++";
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    public double Score { get; set; }
    public string FinalResult { get; set; } = "Pending";
}
