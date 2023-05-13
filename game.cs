using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_game
{
    internal class game
    {
        
        public string human_name = Console.ReadLine();
        public string enemy_name;
        public int human_health;
        public int enemy_health;
        public int ammo = int.Parse(Console.ReadLine());
        

        public game(string human_name, string enemy_name, int human_health, int enemy_health, int ammo)
        {
            this.human_name = human_name;
            this.enemy_name = enemy_name;
            this.human_health = human_health;
            this.enemy_health = enemy_health;
            this.ammo = ammo;
        }

        public void print()
        {
            if (ammo == 10)
            {
                
                Console.WriteLine("Zombie health " + 20 + "!");
                Console.WriteLine("Enemy attacked 5!");
                Console.WriteLine("Your health is 25!");
                
                int l = int.Parse(Console.ReadLine());
               
                if (l == 10) ;
                {
                    Console.WriteLine("Zombie health " + 10 + "!");
                    Console.WriteLine("Enemy atacked 10!");
                    Console.WriteLine("Your health is 15!");

                    int w = int.Parse(Console.ReadLine());
                    if (w == 10)
                    {
                        Console.WriteLine("*************************");
                        Console.WriteLine("You killed the zombie!");
                        Console.WriteLine("*************************");
                    }
                }
            }
        }
    }
}
