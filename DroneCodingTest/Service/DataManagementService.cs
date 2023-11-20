using DroneCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DroneCodingTest.Service
{
    public static class DataManagementService
    {
        public static string ToString(ICollection<Convoy> convoys, ICollection<Drone> drones)
        {
            var response = new StringBuilder();
            foreach (var drone in drones)
            {
                response.AppendLine("[" + drone.Name + "]");
                for (var i = 0; i < convoys.Count; i++)
                {
                    var route = convoys.ElementAt(i).Routes.FirstOrDefault(r => r.Drone.Name == drone.Name);
                    if (route == null)
                        continue;

                    response.AppendLine("Trip #" + (i+1));
                    var first = true;
                    foreach (var location in route.Locations)
                    {
                        response.Append((first ? "" : ",") + "[" + location.Name + "]");
                        first = false;
                    }
                    response.AppendLine();
                }
                response.AppendLine();
            }

            return response.ToString();
        }

        public static void ExtractInformations(string content, out ICollection<Drone> drones, out ICollection<DeliveryLocation> deliveryLocations)
        {
            drones = ExtractDrones(content.Split('\n')[0]);
            deliveryLocations = ExtractDeliveryLocations(content.Substring(content.IndexOf('\n')));
        }

        private static ICollection<Drone> ExtractDrones(string fileContent)
        {
            List<Drone> drones = new List<Drone>();

            var matches = GetDefaultRegexResult(fileContent);
            foreach (Match match in matches)
            {
                drones.Add(new Drone
                {
                    Name = match.Groups[1].Value.Trim(),
                    MaxWeight = decimal.Parse(match.Groups[2].Value.Trim())
                });
            }

            if (drones.Count > 100)
                throw new Exception("The maximum number of drones in a squad is 100.");

            return drones;
        }

        private static ICollection<DeliveryLocation> ExtractDeliveryLocations(string fileContent)
        {
            List<DeliveryLocation> deliveryLocations = new List<DeliveryLocation>();

            var matches = GetDefaultRegexResult(fileContent);
            foreach (Match match in matches)
            {
                deliveryLocations.Add(new DeliveryLocation
                {
                    Name = match.Groups[1].Value.Trim(),
                    PackageWeight = decimal.Parse(match.Groups[2].Value.Trim())
                });
            }

            return deliveryLocations;
        }

        private static MatchCollection GetDefaultRegexResult(string content)
        {
            return Regex.Matches(content, @"\[([^,]+)\], \[([^\]]+)\]");
        }
    }
}
