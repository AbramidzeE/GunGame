using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Dagger : Weapon
    {

        public string Dager { get; set; }
        public int Weight { get; set; }
        
        public Dagger()
        {
            
            GenerateWeight();
           
        }
        public override string ToString()
        {
            if (Weight >= 20)
            {
                Dager = "Dual Dagger"; 
            }
            else
            {
                Dager = "Single Dagger";
            }
            return base.ToString() + $"weight {Weight} It's a {Dager}";
        }

        static Random rnd = new Random();  
        public void GenerateWeight()
        {
            Weight = rnd.Next(0, 40);

           
            
        }

        


        
    }
}
