using Sandbox.Caves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Cave
{
    class Helmet : Equipment //Inherits from Equipment
    {
        public Helmet(string equipName, string equipColour, string purchaseDate, string condition, int qty, double orgUnitCost, string shop) : base(equipName, equipColour, purchaseDate, condition, qty, orgUnitCost, shop)
        {
            EquipType = "Helmet";
            EquipSubType = "Helmet";
        }
        
        public override string Inventory()
        {
            return $"\nThere {(Qty == 1? $"is 1 helmet": $"are {Qty} helmets")}, the cost to replace is £{Qty * ReplaceUnitCost}";
        }

        public string PriceChange()
        {
            if (ReplaceUnitCost == OrgUnitCost)
            {
                return $"\nThe cost has not changed from £{OrgUnitCost}";
            }
            else if (ReplaceUnitCost > OrgUnitCost) 
            {
                return $"\nThe cost has increased by £{ReplaceUnitCost - OrgUnitCost} to £{ReplaceUnitCost}";
            }
            else
            {
                return $"\nThe cost has decreased by £{OrgUnitCost - ReplaceUnitCost} to £{ReplaceUnitCost}";
            }
        }
    }
}
