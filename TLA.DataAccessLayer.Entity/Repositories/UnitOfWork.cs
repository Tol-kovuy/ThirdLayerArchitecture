using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLA.DataAccessLayer.Entity.Context;
using TLA.DataAccessLayer.Entity.Interfaces;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.DataAccessLayer.Entity.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGroupRepository _groupRepository;
        private readonly TLAContext context;
        private GenericRepository<Audience> audienceRepository;
        private GenericRepository<Course> courseRepository;
        private GenericRepository<Student> studentRepository;
        private GenericRepository<Trainer> trainerRepository;

        public UnitOfWork(TLAContext context)
        {
            this.context = context;
        }

        public IRepository<Audience> Audiences =>
            audienceRepository ?? (audienceRepository = new GenericRepository<Audience>(context));

        public IRepository<Course> Courses =>
            courseRepository ?? (courseRepository = new GenericRepository<Course>(context));

        public IRepository<Student> Students =>
            studentRepository ?? (studentRepository = new GenericRepository<Student>(context));

        public IRepository<Trainer> Trainers =>
            trainerRepository ?? (trainerRepository = new GenericRepository<Trainer>(context));

        void IUnitOfWork.Save()
        {
            context.SaveChanges();
        }

        #region Реализация патерна Dispose, что бы не использовать usingi 
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();// TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UnitOfWork() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        void IDisposable.Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            GC.SuppressFinalize(this);
        }
        #endregion
    }

}
