using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public Weapon Weapon { get; set; }
        public int HP { get; set; } = 200;

       
        public int Shoot()
        {
            return Weapon.WeaponPower;
        }

        public override string ToString()
        {
            return $"HP {HP}";
        }
    }
}
