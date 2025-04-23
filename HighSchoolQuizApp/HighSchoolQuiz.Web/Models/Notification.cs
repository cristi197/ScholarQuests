using HighSchoolQuiz.Web.Models.Enums;

namespace HighSchoolQuiz.Web.Models;

public class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = default!;

    public string Message { get; set; } = default!;
    public NotificationType Type { get; set; } = NotificationType.Email;
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
    public bool IsRead { get; set; } = false;
}

