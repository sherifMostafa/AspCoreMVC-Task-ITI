using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabcoreDay2.Repository;

namespace LabcoreDay2.Models
{
    public class studentController : Controller
    {

        studentRepository s;
        public studentController(studentRepository s)
        {
            this.s = s;
        }
        public IActionResult Index()
        {
            return View(s.getall());
        }
    }
}
