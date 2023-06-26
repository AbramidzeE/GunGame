using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GunGame
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Weapon> weapon = new List<Weapon>()
            {
                new Gun()
                {
                    WeaponName = "M4A4",

                },
                new Gun()
                {
                    WeaponName = "AK-47"
                },
                new Bow()
                {
                    WeaponName = "TOPARCHERY"
                },
                new Bow()
                {
                    WeaponName = "BAMBOO"
                },
                new Dagger()
                {
                    WeaponName = "Katana",
                },
                new Dagger()
                {
                    WeaponName = "Blade",

                },
            };



            foreach (var item in weapon)
            {
                Console.WriteLine(item);
            }

            Dagger dagger = new Dagger();
            dagger.GenerateWeight();

            Player player = new Player();
            Console.WriteLine("P1 - Enter Your Name: ");
            player.PlayerName = Console.ReadLine();
            Console.WriteLine($"{player.PlayerName} choose your weapon");

            int wp = int.Parse(Console.ReadLine());
            player.Weapon = weapon[wp];
            for (int i = 0; i < weapon.Count; i++)
            {
                if (wp == i + 1)
                {
                    Console.WriteLine($"{player.PlayerName}'s Gun Detail: {weapon[i]}");
                }
            }

            Player player2 = new Player();
            Console.WriteLine("P2 - Enter Your Name");
            player2.PlayerName = (Console.ReadLine());
            Console.WriteLine($"{player2.PlayerName} choose your weapon");
            int wp2 = int.Parse(Console.ReadLine());
            player2.Weapon = weapon[wp2];

            for (int i = 0; i < weapon.Count; i++)
            {
                if (wp2 == i + 1)
                {
                    Console.WriteLine($"{player2.PlayerName}'s Gun Detail: {weapon[i]}");
                }
            }

            while (player.HP >= 0 && player2.HP >= 0)
            {
                Console.WriteLine("1!");
                Thread.Sleep(700);
                Console.WriteLine("2!");
                Thread.Sleep(700);
                Console.WriteLine("Fight!");
                Thread.Sleep(700);

                int DMG = player2.Shoot();
                player2.HP -= DMG;
                player2.HP = player2.HP < 0 ? 0 : player2.HP;
                Console.WriteLine($"{player2.PlayerName} HP {player2.HP} DMG {DMG}");

                if (player2.HP <= 0)
                    break;

                Console.WriteLine("1!");
                Thread.Sleep(700);
                Console.WriteLine("2!");
                Thread.Sleep(700);
                Console.WriteLine("Fight!");
                Thread.Sleep(700);

                DMG = player2.Shoot();
                player.HP -= DMG;
                player.HP = player.HP < 0 ? 0 : player.HP;
                Console.WriteLine($"{player.PlayerName} HP {player.HP} DMG {DMG}");

            }
           
        }
    }
}
