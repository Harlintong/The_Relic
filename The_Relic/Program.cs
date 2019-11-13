using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Hero MyHero = new Hero();

            GameTitel();

            Console.WriteLine("You wake up from your slumber, you don't remeber anything exept that your name is\n");
            Console.WriteLine("Name: ");
            MyHero.name = Console.ReadLine();
            Console.WriteLine(MyHero.name + " and that your mission is to protect the world");

            Console.WriteLine("Before you there is a sword, you take it and it fuses with you");

            Weapon BlackSword = new Weapon();

            BlackSword.name = "Ancient Sword";
            BlackSword.strenght = 50;
            MyHero.AddToInventory(BlackSword);

            Console.WriteLine("You feel a strong connection to this sword");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("*You aquired " + BlackSword.name + ", it's now added to you inventory*"); Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadLine();
        }

        public static void GameTitel()
        {
                Console.WriteLine(@"
                P
             P /\  P
            /\|  |/\
         [] ||_/\_|| []
         ||_||____||_||
         ||____[]____||
        {::     \__    }
    ___  \v:    .''  _V ___
   (      \_      __ / --  )_
  (__-- -    |::\ :/ ---     )
     (       \::\/ -----___)
      (______  \/ _____)
");
                Console.WriteLine(@"
_________          _______    _______  _______  _       _________ _______ 
\__   __/|\     /|(  ____ \  (  ____ )(  ____ \( \      \__   __/(  ____ \
   ) (   | )   ( || (    \/  | (    )|| (    \/| (         ) (   | (    \/
   | |   | (___) || (__      | (____)|| (__    | |         | |   | |      
   | |   |  ___  ||  __)     |     __)|  __)   | |         | |   | |      
   | |   | (   ) || (        | (\ (   | (      | |         | |   | |      
   | |   | )   ( || (____/\  | ) \ \__| (____/\| (____/\___) (___| (____/\
   )_(   |/     \|(_______/  |/   \__/(_______/(_______/\_______/(_______/
                                                                          
");
            Console.WriteLine("Press any button to continue");

            Console.ReadLine();
        }

        public static void first()
        {

        }



            
        
    }
}
