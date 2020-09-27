

namespace TLA.DataAccessLayer.Entity.Models
{
    public class Audience
    {
        public int Id { get; set; }
        public int? RoomNumber { get; set; }
        public bool Online { get; set; }
    }
}
