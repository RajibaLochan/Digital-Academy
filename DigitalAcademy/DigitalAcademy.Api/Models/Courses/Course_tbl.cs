using System.ComponentModel.DataAnnotations;

namespace DigitalAcademy.Model
{
    public class Course_tbl
    {
        [Key]
        public long courseid { get; set; }
        public string coursename { get; set; }
        public string courseduration { get; set; } // Month

    }
}
