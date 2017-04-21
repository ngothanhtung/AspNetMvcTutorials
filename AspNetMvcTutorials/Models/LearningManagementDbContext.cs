using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTutorials.Models
{
    public class LearningManagementDbContext : DbContext
    {
        public LearningManagementDbContext() : base("name=LearningManagementConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<Student> Students { get; set; }
    }
}
