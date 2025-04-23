namespace HighSchoolQuiz.Web.Models;

public class Suggestion
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public string Type { get; set; } = null!; // Problem / Theory / Site
    public string Description { get; set; } = null!;
    public string Status { get; set; } = "New"; // New / InProgress / Resolved
}
