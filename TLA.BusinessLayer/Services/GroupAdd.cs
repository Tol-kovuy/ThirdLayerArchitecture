using System.Collections.Generic;
using TLA.DataAccessLayer.Entity.Context;
using TLA.DataAccessLayer.Entity.Models;

namespace TLA.BusinessLayer.Services
{
    class GroupAdd
    {
        private readonly TLAContext db = new TLAContext();
        public void AddGroups()
        {
            Group g1 = new Group { Name = "Funny Gays", TrainerId = 1 };

            g1.Students.Add(new Student { FirstName = "Janna", LastName = "Dark", Gender = "Woman", Extramural = true });
            g1.Students.Add(new Student { FirstName = "Joe", LastName = "Cocker", Gender = "Man" });
            g1.Students.Add(new Student { FirstName = "Gianna", LastName = "Michaes", Gender = "Woman", Extramural = true });
            g1.Students.Add(new Student { FirstName = "Stive", LastName = "Vai", Gender = "Man", Extramural = true });
            g1.Courses.Add(new Course { Name = "OOP" });
            g1.Courses.Add(new Course { Name = "EntityFramework" });
            g1.Audience.Online = true;
            g1.Trainer.FirstName = "Roman";
            g1.Trainer.LastName = "Volyk";


            Group g2 = new Group { Name = "Bad Gays", TrainerId = 2 };

            g2.Students.Add(new Student { FirstName = "Brother", LastName = "Appachi", Gender = "Man" });
            g2.Courses.Add(new Course() { Name = "EntityFramework" });
            g2.Audience.RoomNumber = 13;
            g2.Trainer.FirstName = "David";
            g2.Trainer.LastName = "Boyarov";


            db.Groups.AddRange(new List<Group> { g1, g2 });
            db.SaveChanges();
        }

    }
}
