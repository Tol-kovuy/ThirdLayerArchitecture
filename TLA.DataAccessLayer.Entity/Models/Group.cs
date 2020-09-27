
using System.Collections.Generic;


namespace TLA.DataAccessLayer.Entity.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int? AudienceId { get; set; }
        public Audience Audience { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
    }
}
