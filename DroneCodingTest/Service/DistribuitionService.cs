using DroneCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DroneCodingTest.Service
{
    public static class DistribuitionService
    {
        public static ICollection<Convoy> CalculateWeightDistribuition(ICollection<Drone> drones, ICollection<DeliveryLocation> deliveryLocations)
        {
            deliveryLocations = deliveryLocations.OrderByDescending(l => l.PackageWeight).ToList();
            drones = drones.OrderByDescending(d => d.MaxWeight).ToList();

            ICollection<Convoy> convoys = new List<Convoy>();
            foreach (var location in deliveryLocations)
            {
                if (!drones.Any(d => d.MaxWeight >= location.PackageWeight))
                    throw new Exception("Package too weight to any drone.");

                var convoy = convoys.FirstOrDefault(c => c.Routes.Any(r => r.RemainingWeight >= location.PackageWeight) || c.Routes.Count != drones.Count);
                if (convoy == null)
                {
                    convoy = new Convoy();
                    convoys.Add(convoy);
                }
                else
                {
                    var route = convoy.Routes.FirstOrDefault(r => r.RemainingWeight >= location.PackageWeight);
                    if (route != null)
                    {
                        route.AddLocation(location);
                        continue;
                    }
                }

                var newDrone = drones.FirstOrDefault(d => d.MaxWeight >= location.PackageWeight && !convoy.Routes.Any(r => r.Drone.Name == d.Name));
                if (newDrone == null)
                {
                    convoy = new Convoy();
                    convoys.Add(convoy);
                    newDrone = drones.FirstOrDefault(d => d.MaxWeight >= location.PackageWeight);
                }

                convoy.Routes.Add(new Route(newDrone, location.PackageWeight, location));
            }

            return convoys;
        }
    }
}
