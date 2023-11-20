using System.Collections.Generic;

namespace DroneCodingTest.Models
{
    public class Route
    {
        public Drone Drone { get; set; }
        public decimal RemainingWeight { get; set; }
        public ICollection<DeliveryLocation> Locations { get; set; } = new List<DeliveryLocation>();

        public Route(Drone drone, decimal packageWeight, DeliveryLocation location)
        {
            Drone = drone;
            RemainingWeight = drone.MaxWeight - packageWeight;
            Locations.Add(location);
        }

        public void AddLocation(DeliveryLocation location)
        {
            RemainingWeight -= location.PackageWeight;
            Locations.Add(location);
        }
    }
}
