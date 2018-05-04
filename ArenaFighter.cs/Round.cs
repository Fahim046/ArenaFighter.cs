using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter.cs
{
    class Round
    {
        
        public Character player;
        public Character opponent;
        Battle BT;

  //********** Fight Function receive Player and Opponent and Starts the Fight ***************************
                        
        public int  Fight(Character ob, Character obj1, Battle battle) {
            this.BT = battle;
            Random rnd = new Random();
            player =  ob;
            opponent = obj1;

            
            while (player.Health >0 && opponent.Health > 0)
            {
               
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);

                player.Power = dice1;
                opponent.Power = dice2;

                Console.WriteLine(player.Name + " " + " Power " + " " + player.Power + " " + opponent.Name + " " + " Power " + " " + opponent.Power);

                if (player.Power > opponent.Power)
                {

                    Console.WriteLine("Press enter to attack : " + " " + opponent.Name);
                    Console.ReadLine();
                                   
                    opponent.Health = opponent.Health - player.damage;
                    
                    Console.WriteLine(player.Name + " " + " Health " + player.Health + " " + opponent.Name + " Health " + opponent.Health);

                    Console.ReadLine();
                }

                if (opponent.Power > player.Power)
                {
                    Console.WriteLine("Press enter to attack : " + " " + player.Name);
                    Console.ReadLine();

                    player.Health = player.Health - opponent.damage;

                    Console.WriteLine(player.Name + " " + " Health " + player.Health + " " + opponent.Name + " Health " + opponent.Health);
                    Console.ReadLine();

                }

                if (player.Power == opponent.Power)
                {
                    Console.WriteLine("Tie...Roll the Dice again... ");
                }
                
            }

            if (player.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine(opponent.Name + " " + "won the Game");
                Console.WriteLine(player.Name + " : " + "Dead");
                Console.WriteLine(player.Name + " " + " killed by " + " " + opponent.Name);
                                              
                BT.Show_statistics();
                
            }

            if (opponent.Health <= 0)
            {

                Console.WriteLine(opponent.Name + " " + " is " + "Dead");
                Console.WriteLine("Enter H -  To Hunt for an Opponent:");
                Console.WriteLine("Enter R - To Retire from fighting:");
                String s = Console.ReadLine();
                Console.Clear();

     // *********** Check Again if Player want to Fight or Retire  ******************

                if (s == "R")
                {
                    Console.WriteLine("You decided to Retire ...");
                    BT.Score.Add(5);
                    BT.Victims.Add(opponent.name);
                    BT.Show_statistics();    

                }

                if (s == "H")
                {
                    BT.Victims.Add(opponent.name);
                    BT.Score.Add(5);
                    Character opponent2 = new Character();
                    Console.WriteLine("Opponent:" + opponent2.name);
                    Console.WriteLine("Health:" + opponent2.health);
                    Console.WriteLine("Damage:" + opponent2.damage);
                    Console.ReadKey();

                    Fight(player, opponent2, this.BT);
                }

            }                                 
                                           
            Console.ReadKey();

            return 0;
        }





    }
}
