using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAcademy.Model
{
    public class Student_tbl
    {
        [Key]
        public long student_id { get; set; }
        public string student_fname { get; set; }
        public string student_mname { get; set; }
        public string student_lname { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime dateofbirth { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public int pincode { get; set; }
        [ForeignKey("Country_tbl")]
        public Nullable<long> country_id { get; set; }
        public string country { get; set; }
        [ForeignKey("State_tbl")]
        public Nullable<long> state_id { get; set; }
        public string state { get; set; }
        [ForeignKey("City_tbl")]
        public Nullable<long> city_id { get; set; }
        public string city { get; set; }
        public bool isactive { get; set; }
        public bool isfranchiesestudent { get; set; } // Digital acedemy ==false // true means francisese  
        public Student_tbl()
        {
            this.isactive = true;
        }
    }
}
