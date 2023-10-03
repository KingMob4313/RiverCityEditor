using System;
namespace RiverCityEditor
{
    public class Product
    {
        //0x00A4F9 = Array[128] of pointer to item records indexed by ItemNumber

        //Each item record:
        //* [variable] item name terminated by 05
        //* [03 bytes] YZ WX 0V: item cost $VWX.YZ(digits are BCD)
        //* [03 bytes] ?? ?? ??: unknown
        //* [01 byte] Abilities enhanced bitmask:
        //    * 7 = punch
        //    * 6 = kick
        //    * 5 = weapon
        //    * 4 = throw
        //    * 3 = agility
        //    * 2 = defense
        //    * 1 = strength
        //    * 0 = will power
        //* [01 byte] Status enhanced bitmask:
        //    * 7 = stamina
        //*[variable] Variable length array of ability values, in the order above.
        // Array element is present only if corresponding bit is set above.

        private int itemId;
        private string itemName;
        private int itemCost;
        private int itemPrice;

        private int punchBonus;
        private int kickBonus;
        private int weaponBonus;
        private int throwBonus;
        private int agilityBonus;
        private int defenseBonus;
        private int strengthBonus;
        private int willpowerBonus;

        private int stamina;

        public int ItemId { get => itemId; set => itemId = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int ItemCost { get => itemCost; set => itemCost = value; }
        public int ItemPrice { get => itemPrice; set => itemPrice = value; }
        public int PunchBonus { get => punchBonus; set => punchBonus = value; }
        public int KickBonus { get => kickBonus; set => kickBonus = value; }
        public int WeaponBonus { get => weaponBonus; set => weaponBonus = value; }
        public int ThrowBonus { get => throwBonus; set => throwBonus = value; }
        public int AgilityBonus { get => agilityBonus; set => agilityBonus = value; }
        public int DefenseBonus { get => defenseBonus; set => defenseBonus = value; }
        public int StrengthBonus { get => strengthBonus; set => strengthBonus = value; }
        public int WillpowerBonus { get => willpowerBonus; set => willpowerBonus = value; }
        public int Stamina { get => stamina; set => stamina = value; }
    }
}