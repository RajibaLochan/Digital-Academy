using DigitalAcademy.Api.Data;
using DigitalAcademy.Api.Repositories;
using DigitalAcademy.Api.Utility;
using DigitalAcademy.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        //private readonly IStudentRepository _student;
        private readonly DigitalAcademyDbContext _context;
        public StudentController(ILogger<StudentController> logger, DigitalAcademyDbContext context)
        {
            _logger = logger;
            //_student = student;
            _context = context;
        }
        [HttpPost("Login", Name = "Login")]
        public ActionResult<bool> Login(StudentLogin student)
        {
            bool islogged = false;
            try
            {
                if (student.username == "student" && student.password == "student")
                {
                    return true;
                }
                else
                {
                    islogged = false;
                }
                //islogged = _student.StudentLogin(student);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Login action: {ex.Message}");
            }
            return islogged;
        }
        [HttpPost(Name = "StudentRegister")]
        public ActionResult StudentRegister(Student_tbl student)
        {
            try
            {
                //_context.Students.Add(student);
                //_context.SaveChanges();
                return Ok(student);
            }
            catch (Exception ex)
            {
                _logger.LogError("StudentRegister : " + ex.Message);
                return BadRequest();
            }

        }
        [HttpGet(Name = "GetWeatherForecast33")]
        public string GetRRRR()
        {
            return "Hello";
        }
    }
}
