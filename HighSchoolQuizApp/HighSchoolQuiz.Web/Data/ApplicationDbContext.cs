using Microsoft.EntityFrameworkCore;

namespace HighSchoolQuiz.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}
