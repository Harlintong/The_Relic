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
            Hero theHero = new Hero();

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

            Console.ReadLine();

            Console.WriteLine("You woke up in a dark cave, you don't know why you are there but you know your name is...");

            Hero.name = Console.ReadLine();

            Console.WriteLine("You got up and walked to the entranced of the cave, it seemed to not be naturaly structured\n in front of the entrance a sword stod inpaled in a stoned");

            Console.WriteLine("You took it");

            Hero.AddToInventory();
        }
    }
}
