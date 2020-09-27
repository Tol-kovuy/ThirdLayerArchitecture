using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLA.DataAccessLayer.Entity.Context;
using TLA.DataAccessLayer.Entity.Interfaces;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.DataAccessLayer.Entity.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public TLAContext Database { get; set; }

        public GroupRepository(TLAContext context) 
        {
            Database = context;
        }

        public IEnumerable<Group> GetAll()
        {
            return Database.Groups;
        }

        public Group Get(string id)
        {
            return Database.Groups.Find(id);
        }

        public void Create(Group item)
        {
            Database.Groups.Add(item);
        }

        public void Update(Group item)
        {
            Database.Entry(item).State = EntityState.Modified;
        }

        public void Delete(string id)
        {
            Group group = Database.Groups.Find(id);
            if (group != null)
                Database.Groups.Remove(group);
        }

        public IEnumerable<Group> Find(Func<Group, bool> predicate)
        {
            return Database.Groups.Where(predicate).ToList();
        }
    }
}
