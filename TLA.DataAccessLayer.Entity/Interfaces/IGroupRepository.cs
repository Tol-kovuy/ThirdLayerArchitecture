using System;
using System.Collections.Generic;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.DataAccessLayer.Entity.Interfaces
{
    public interface IGroupRepository 
    {
        IEnumerable<Group> GetAll();
        Group Get(string id);
        void Create(Group item);
        void Update(Group item);
        void Delete(string id);
        IEnumerable<Group> Find(Func<Group, bool> predicate);
    }
}
