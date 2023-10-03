using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverCityEditor
{
    public class GangMember
    {
        private int gangId;
        private string name;
        private int stamina;
        private int punch;
        private int kick;
        private int weapon;
        private int throwing;
        private int agility;
        private int defense;
        private int strength;
        private int willpower;
        private int cash;

        public int GangId { get => gangId; set => gangId = value; }
        public string Name { get => name; set => name = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Punch { get => punch; set => punch = value; }
        public int Kick { get => kick; set => kick = value; }
        public int Weapon { get => weapon; set => weapon = value; }
        public int Throwing { get => throwing; set => throwing = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Willpower { get => willpower; set => willpower = value; }
        public int Cash { get => cash; set => cash = value; }
    }
}
