using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Weapon
    {
        public string WeaponName{ get; set; }
        public int WeaponPower { get; set; }
        public int Lethality { get; set; }

        public Weapon()
        {
            FillPower();
            FillLethality();
        }
     
        public override string ToString()
        {
            return $"WeaponName {WeaponName} WeaponPower {WeaponPower} Lethality {Lethality} ";
        }

        static Random rnd = new Random();

        public  void FillPower()
        {
            WeaponPower = rnd.Next(40,80);
        }

        public  void  FillLethality()
        {

            Lethality = rnd.Next(0, 100);

        }

       
    }

}
