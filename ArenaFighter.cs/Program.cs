using System;

namespace ArenaFighter.cs
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Console.WriteLine("##############################      Welcome to the Arena Fighter Game     ##############################");
            
            Battle BT = new Battle();

// **************  Set player Name, Health, Damage ******************

            Console.WriteLine("Enter Player name:");
            String a=Console.ReadLine();

            Character player = new Character(a);
            Console.WriteLine("Name:" + a);
            Console.WriteLine("Health:"+ player.health);
            Console.WriteLine("Damage:" + player.damage);


            Console.WriteLine("What do you want to do...?");
            Console.WriteLine("Enter H -  To Hunt for an Opponent:");
            Console.WriteLine("Enter R - To Retire from fighting:");
            String st = Console.ReadLine();
            Console.Clear();

            // ***********  Condition to check if Player want to Fight or Retire ******************
            if (st == "H")
            {

                Character opponent = new Character();
                Console.WriteLine("Opponent:" + opponent.Name);
                Console.WriteLine("Health:" + opponent.health);
                Console.WriteLine("Damage:" + opponent.damage);
                Console.ReadKey();

                //  ***********  Send player and opponent to Battle Class for HealthCheck  *****************
                BT.CheckHealth(player, opponent);

                Console.Clear();

            }

            if (st == "R")
            {
                Console.WriteLine("You Decided not to Fight...!!!");
                Console.WriteLine(player.Name + " " + " score : 0");

                Console.WriteLine("*********************************************");
                Console.WriteLine("Press Enter to exit:");
                Console.ReadLine();
                
            }
                    
        }
    }
}
