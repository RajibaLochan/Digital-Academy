using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAcademy.Model
{
    public class City_tbl
    {
        [Key]
        public long city_id { get; set; }
        public string city { get; set; }
        [ForeignKey("State_tbl")]
        public Nullable<long> state_id { get; set; }
    }
}
