using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Gun : Weapon
    {
        public int BulletQuantiti { get; set; }

        public Gun()
        {
            FillBUllet();
        }
        public override string ToString()
        {
            return base.ToString() + $" BulletQuantiti {BulletQuantiti}";
        }
        static Random rnd = new Random();

        public  void FillBUllet()
        {

            BulletQuantiti = rnd.Next(30, 40);
        }
        
    }
}
