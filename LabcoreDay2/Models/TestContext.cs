using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LabcoreDay2.Models
{
    public class TestContext : DbContext
    {


        public TestContext(DbContextOptions<TestContext>options):base(options)
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
    }
}
