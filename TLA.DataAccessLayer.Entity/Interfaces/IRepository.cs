using System;
using System.Collections.Generic;

namespace TLA.DataAccessLayer.Entity.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();    // получение всех объектов
        TEntity Get(int id);             // получение одного объекта по id
        void Create(TEntity entity);   // создание объекта
        void Update(TEntity entity);   // обновление объекта
        void Delete(TEntity entity);      // сохранение изменений
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate); // поиск обьекта
    }
}
