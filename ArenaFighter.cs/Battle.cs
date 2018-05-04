using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter.cs
{
    class Battle
    {

        public Character O;
        public Character P;

        public List<int> Score = new List<int>();
        public List<string> Victims = new List<string>();

        public void CheckHealth(Character ob, Character obj1)
        {

            O = ob;
            P = obj1;

            Round R = new Round();

            R.Fight(O, P, this);
          
        }

        public void Show_statistics()

        {
            int d = 0;
            int b = 0;
            string c = null;

            foreach (int sc in Score)
            {

                b = b + sc;

            }

            foreach (string st in Victims)
            {
                c = c + st;
                Console.WriteLine(O.Name + " " + " Killed " + " " + c);
                d = d + 1;
            }
            Console.WriteLine(O.Name + " " + "won" + " " + d + " " + "Games");
            Console.WriteLine("Score:" + b);

            Console.WriteLine("*********************************************");
            Console.WriteLine("Press Enter to exit:");

            Console.ReadKey();

        }
      
    }

}




    
