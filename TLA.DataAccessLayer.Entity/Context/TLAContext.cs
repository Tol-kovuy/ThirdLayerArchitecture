using System;
using System.Collections.Generic;
using System.Data.Entity;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.DataAccessLayer.Entity.Context
{
    public class TLAContext : DbContext
    {
        public TLAContext()
            : base("name=TLA.Context")
        {
        }

        public virtual DbSet<MyModel> MyModels { get; set; }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Audience> Audiences { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
