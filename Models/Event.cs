using System;
using System.Collections.Generic;

namespace SubConnect.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int MaxParticipants { get; set; }
        public List<string> RegisteredParticipants { get; set; } = new List<string>();
    }
}
