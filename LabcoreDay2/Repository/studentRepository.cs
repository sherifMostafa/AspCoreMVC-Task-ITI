using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabcoreDay2.Models;


namespace LabcoreDay2.Repository
{
    public class studentRepository
    {
        TestContext db;

        public studentRepository(TestContext db)
        {
            this.db = db;
        }


        public List<Student> getall()
        {
            return db.Students.ToList();
        }

        public Student getbyId(int id)
        {
            return db.Students.Find(id);
        }

        public void add(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            Student s = db.Students.Find(id);
            db.Students.Remove(s);
            db.SaveChanges();

        }

    }
}
