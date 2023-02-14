using Sandbox.Caves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Cave
{
    class Carabiner : Equipment //Inherits from Equipment
    {
        public Carabiner(string equipName, string equipSubType, string equipColour, string purchaseDate, string condition, int qty, double orgUnitCost, string shop) : base(equipName, equipSubType, equipColour, purchaseDate, condition, qty, orgUnitCost, shop)
        {
            EquipType = "Carabiner";
        }
        
        public override string Inventory()
        {
            return $"\nThere {(Qty == 1? $"is 1 Carabiner" : $"are {Qty} Carabiners")}, the cost to replace is £{(Qty * ReplaceUnitCost).ToString("0.00")}";
        }
    }
}
