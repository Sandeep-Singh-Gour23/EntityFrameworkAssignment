using EntityFrameworkAssignment.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkAssignment.StudentContext
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
