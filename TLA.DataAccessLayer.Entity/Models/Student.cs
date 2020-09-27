

namespace TLA.DataAccessLayer.Entity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Extramural { get; set; }
        public string Gender { get; set; }
    }
}
