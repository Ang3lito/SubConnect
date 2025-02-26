using System.Collections.Generic;

namespace SubConnect.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsOrganizer { get; set; }
        public List<int> RegisteredEvents { get; set; } = new List<int>();
    }
}
