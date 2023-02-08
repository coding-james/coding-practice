using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Caves
{
    public class Cave
    {
        public string Name { get; private set; }
        public string Region { get; protected set; }
        public string GridRef { get; protected set; }
        public int Length { get; protected set; }
        public int Depth { get; protected set; }
        public string Water { get; protected set; }
        public bool FloodRisk { get; protected set; }
        public int Trips { get; protected set; }

        public Cave(string name, string region, string gridRef, int length, int depth, string water, bool floodRisk)
        {
            Name = name;
            Region = region;
            GridRef = gridRef;
            Length = length;
            Depth = depth;
            Water = water;
            FloodRisk = floodRisk;
            Trips = 0;
        }

        public virtual void AddTrip()
        {
            Trips++;
        }

        public string Describe()
        {
            return $"\n{Name} is locted in the {Region}. The cave is {Length}m long and {Depth}m deep. It is a {Water} and {(FloodRisk ? "does" : "does not")} have a risk of flooding. You have done {(Trips == 1? Trips + " trip": Trips + " trips")}";
        }
    }
}
