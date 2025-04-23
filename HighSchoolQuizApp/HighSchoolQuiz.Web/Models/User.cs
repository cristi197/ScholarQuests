using HighSchoolQuiz.Web.Models.Enums;

namespace HighSchoolQuiz.Web.Models;
public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public string? PhoneNumber { get; set; }
    public UserRole Role { get; set; } = UserRole.Guest; // Student, Teacher, Admin, Guest
    public bool NotifyBySms { get; set; } = false;
    public bool NotifyByEmail { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int? ClassId { get; set; }
    public Class? Class { get; set; }

    public int? HighSchoolId { get; set; }
    public HighSchool? HighSchool { get; set; }

    public ICollection<Homework>? AssignedHomeworks { get; set; }
    public ICollection<Problem>? ProposedProblems { get; set; }
    public ICollection<Solution>? Solutions { get; set; }
    public ICollection<Suggestion>? Suggestions { get; set; }
    public ICollection<Notification>? Notifications { get; set; }
}

