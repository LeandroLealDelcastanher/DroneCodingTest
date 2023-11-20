using System.Collections.Generic;

namespace DroneCodingTest.Models
{
    public class Convoy
    {
        public ICollection<Route> Routes { get; set; } = new List<Route>();
    }
}
