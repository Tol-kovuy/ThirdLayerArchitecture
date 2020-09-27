using System;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.DataAccessLayer.Entity.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Audience> Audiences { get; }
        IRepository<Course> Courses { get; }
        IRepository<Student> Students { get; }
        IRepository<Trainer> Trainers { get; }
        void Save();
    }
}
