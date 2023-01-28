using DigitalAcademy.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DigitalAcademy.Api.Data
{
    public class DigitalAcademyDbContext: DbContext
    {
        public DigitalAcademyDbContext(DbContextOptions<DigitalAcademyDbContext> options):base(options)
        {
                
        }
        public DbSet<Country_tbl> Country_Tbls { get; set; }
        public DbSet<State_tbl> State_Tbls { get; set; }
        public DbSet<City_tbl> City_Tbls { get; set; }
        public DbSet<Course_tbl> Course_Tbls { get; set; }
        public DbSet<Student_tbl> Student_Tbls { get; set; }
    }

}
