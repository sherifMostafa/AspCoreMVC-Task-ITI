using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabcoreDay2.Models
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string Desc { get; set; }
        public string Pdf { get; set; }

        public DateTime data { get; set; }

        [ForeignKey("student")]
        public int? stude_id { get; set; }

        public virtual Student student { get; set; }
    }
}
