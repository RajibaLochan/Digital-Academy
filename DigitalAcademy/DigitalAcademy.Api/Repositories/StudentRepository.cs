using DigitalAcademy.Api.Data;

namespace DigitalAcademy.Api.Repositories
{
    public class StudentRepository
    {
        public readonly DigitalAcademyDbContext _dbContext;
        public StudentRepository(DigitalAcademyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
