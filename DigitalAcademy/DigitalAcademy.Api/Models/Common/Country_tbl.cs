using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAcademy.Model
{
    public class Country_tbl
    {
        [Key]
        public long country_id { get; set; }
        public string country { get; set; }
    }
}
