using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabcoreDay2.Models;

namespace LabcoreDay2.Repository
{
    public class projectRepository
    {
          TestContext db;
          

            public projectRepository(TestContext db)
            {
                this.db = db;
            }

            public List<Project> getall()
            {
                return db.Projects.ToList();
            }

            public Project getbyId(int id)
            {
                return db.Projects.Find(id);
            }

            public void add(Project p)
            {
                p.data = DateTime.Now;
                db.Projects.Add(p);
                db.SaveChanges();
            }

            public void delete(int id)
            {
                Project s = db.Projects.Find(id);
                db.Projects.Remove(s);
                db.SaveChanges();
            }

           

            public void edite(Project p)
            {
                Project pp = db.Projects.Find(p.id);
                pp.id = p.id;
                pp.name = p.name;
                pp.Desc = p.Desc;
                pp.stude_id = p.stude_id;
                db.SaveChanges();
            }

    }
 }
