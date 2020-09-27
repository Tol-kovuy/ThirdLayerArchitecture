using System;
using System.Collections.Generic;
using TLA.BusinessLayer.Interfaces;
using TLA.DataAccessLayer.Entity.Context;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.BusinessLayer
{
    public class ModelService : IDisposable
    {
        private readonly TLAContext db = new TLAContext();

        public GroupDto Create(GroupDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public GroupDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> GetAll()
        {
            return db.Groups;
        }

        public IEnumerable<GroupDto> GetAllGroups()
        {
            throw new NotImplementedException();
        }

        public GroupDto Update(GroupDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
