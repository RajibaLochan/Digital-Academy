using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAcademy.Model
{
    public class State_tbl
    {
        [Key]
        public long state_id { get; set; }
        public string state { get; set; }
        [ForeignKey("Country_tbl")]
        public Nullable<long> country_id { get; set; }
    }
}
