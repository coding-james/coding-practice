using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Caves
{
    abstract class Equipment
    {
        public string EquipName { get; protected set; } // protected - Access is limited to the containing class or types derived from the containing class.
        public string EquipType { get; protected set;  }
        public string EquipSubType { get; protected set; }
        public string EquipColour { get; protected set; }
        public string PurchaseDate { get; protected set; }
        public string Condition { get; protected set; }
        public int Qty { get; protected set; }
        public double OrgUnitCost { get; protected set; }
        public double ReplaceUnitCost { get; protected set; }
        public string Shop { get; protected set; }

        // Constructors / Overloading
        public Equipment(string equipName, string equipColour, string purchaseDate, string condition, int qty, double orgUnitCost, string shop)
        {
            EquipName = equipName;
            EquipType = "";
            EquipSubType = "";
            EquipColour = equipColour;
            PurchaseDate = purchaseDate;
            Condition = condition;
            Qty = qty;
            OrgUnitCost = orgUnitCost;
            ReplaceUnitCost = orgUnitCost;
            Shop = shop;
        }

        public Equipment(string equipName, string equipType, string equipSubType, string equipColour, string purchaseDate, string condition, int qty, double orgUnitCost, double replaceUnitCost, string shop)
        {
            EquipName = equipName;
            EquipType = equipType;
            EquipSubType = equipSubType;
            EquipColour = equipColour;
            PurchaseDate = purchaseDate;
            Condition = condition;
            Qty = qty;
            OrgUnitCost = orgUnitCost;
            ReplaceUnitCost = replaceUnitCost;
            Shop = shop;
        }

        // Methods / Functions
        public virtual void AddQty(int quantity)
        {
            Qty += quantity;
        }

        public virtual void RemoveQty(int quantity)
        {
            Qty -= quantity;

            if (Qty > 0)
            {
                Qty = 0;
            }
        }

        public virtual void UpdateReplaceCost(double newPrice) //virtual allows the method to be overriden in a derived class
        {
            ReplaceUnitCost = newPrice;
        }

        public abstract string Inventory(); //abstract methods are implemented/defined in a derived class   

        public virtual string Details()
        {
            return $"\n{EquipName} is a {(EquipSubType == EquipType? EquipType: $"{EquipSubType} of {EquipType}s")} and was purchased from {Shop}";
        }
    }
}
