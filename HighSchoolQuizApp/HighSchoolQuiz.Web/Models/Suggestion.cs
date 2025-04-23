using HighSchoolQuiz.Web.Models.Enums;

namespace HighSchoolQuiz.Web.Models;

public class Suggestion
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = default!;

    public SuggestionType Type { get; set; } = SuggestionType.Problem;
    public string Description { get; set; } = default!;
    public string Status { get; set; } = "New"; // New / InProgress / Resolved
}
