using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter.cs
{
    class Character
    {
        InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);
        public static Random rnd = new Random();

        public String name;
        public int health;
        public int power;
        public int damage;

//************ Opponent Constructor *******************
        public Character()
        {
            this.name= infoGen.NextFullName();
            this.damage = rnd.Next(1, 5);
            this.health = rnd.Next(1, 7);
        }

 //******* Player Constructor **************

        public Character(String name) : this()
        {

            this.name = name;

        }
                    
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health {
            get { return health; }
            set { health = value; }
        }
        
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        
        



    }
}
