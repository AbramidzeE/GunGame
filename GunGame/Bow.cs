using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Bow : Weapon
    {
        public int Accuracy { get; set; }
        public int ArrowQuantity { get; set; }
        public Bow()
        {
            GenerateArrowQuantity();
            generateAccuracy();
        }
        public override string ToString()
        {
            return base.ToString() + $"Accuracy {Accuracy} ArrowQuantity {ArrowQuantity}";
        }

        Random Random = new Random();
        public void generateAccuracy()
        {
            Accuracy = Random.Next(0,100);
        }
        public void GenerateArrowQuantity()
        {
            ArrowQuantity = Random.Next(Accuracy, 100 );
        }

    }
}
