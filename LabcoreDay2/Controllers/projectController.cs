using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabcoreDay2.Repository;
using LabcoreDay2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LabcoreDay2.Controllers
{
    public class projectController : Controller
    {
        projectRepository p;
        studentRepository s;
        public projectController(projectRepository p , studentRepository s)
        {
            this.p = p;
            this.s = s;
        }
        public IActionResult Index()
        {
            return View(p.getall());
        }

        public IActionResult create()
        {
            ViewBag.students = new SelectList(s.getall(), "id", "name");
            return View();
        }
        [HttpPost]
        public IActionResult create(Project pp)
        {
            p.add(pp);
            return RedirectToAction("Index");
        }

        public IActionResult delete(int id)
        {
            p.delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult edite(int id)
        {
            ViewBag.students = new SelectList(s.getall(), "id", "name");
            return View(p.getbyId(id));
        }

        [HttpPost]
        public IActionResult edite(Project pp)
        {
            p.edite(pp);
            return RedirectToAction("Index");
        }


    }
}
