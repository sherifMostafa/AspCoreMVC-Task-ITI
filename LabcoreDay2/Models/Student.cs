using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabcoreDay2.Models
{
    public class Student
    {

        public Student()
        {
            projects = new List<Project>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public string University { get; set; }
        public string Cv { get; set; }
        public string pic { get; set; }

        public virtual List<Project> projects { get; set; }
    }
}
