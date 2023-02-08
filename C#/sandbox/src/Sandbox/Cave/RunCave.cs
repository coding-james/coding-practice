using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Caves;

namespace Sandbox.Cave
{
    internal class RunCave
    {
        public static void Run()
        {
                Caves.Cave swildons = new Caves.Cave("Swildon's Hole", "Mendips", "ST 531 512", 9146, 167, "Wet Cave", true);
                Caves.Cave goatchurch = new Caves.Cave("Goatchurch Cavern", "Mendips", "ST 475 582", 750, 55, "Dry Cave", false);
                swildons.AddTrip();
                swildons.AddTrip();
                swildons.AddTrip();
                goatchurch.AddTrip();
                Console.WriteLine(swildons.Describe());
                Console.WriteLine(goatchurch.Describe());

                Helmet panga2023 = new Helmet("Petzl Panga", "Orange", "01/02/2023", "New", 1, 42.50, "Up and Under");
                Console.WriteLine(panga2023.Inventory());
                panga2023.AddQty(3);
                panga2023.UpdateReplaceCost(50.00);
                Console.WriteLine(panga2023.Inventory());
                Console.WriteLine(panga2023.PriceChange());
                Console.WriteLine(panga2023.Details());           
        }
        
    }
}
