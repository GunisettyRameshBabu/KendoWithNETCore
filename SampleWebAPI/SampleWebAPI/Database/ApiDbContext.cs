using Microsoft.EntityFrameworkCore;

namespace SampleWebAPI.Database
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentHobbies> StudentHobbies { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>(cfg =>
            {
                cfg.HasKey(e => e.Id);
                cfg.Property(e => e.Name)
                    .IsRequired();
            });

            builder.Entity<StudentHobbies>(cfg =>
            {
                cfg.HasKey(e => e.Id);
                cfg.Property(e => e.Hobbie)
                    .IsRequired()
                    .HasMaxLength(128);
                cfg.Property(e => e.StudentId)
                    .IsRequired();
            });
        }
    }
}
