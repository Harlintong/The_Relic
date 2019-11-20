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
            MyHero.hp = 100;
            MyHero.strenght = 20;

            while (MyHero.hp >= 0)
            {
                GameTitel();

                Console.WriteLine("You wake up from your slumber, you don't remeber anything exept that your name is...\n");
                Console.Write("Name: ");
                MyHero.name = Console.ReadLine();
                Console.WriteLine(MyHero.name + " and that your mission is to protect the world");

                Console.ReadLine();

                Console.WriteLine("Before you there is a sword, you take it and it fuses with you");

                Weapon BlackSword = new Weapon();

                BlackSword.name = "Ancient Sword";
                BlackSword.strenght = 50;
                MyHero.AddToInventory(BlackSword);

                Console.ReadLine();

                Console.WriteLine("You feel a strong connection to this sword");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("*You aquired " + BlackSword.name + ", it's now added to you inventory*"); Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("You hear a loud roar from a village in the distance, you ran to there to see the situation\nIn the way there some villager where evacuating");
                Console.WriteLine("The villagers told you that the village where being attacked by monsters\nyou started going to the village to help you when a woman stoped you and asked to help save their family and gave you some potions");

                Potion grandRedPotion = new Potion();
                grandRedPotion.name = "grand red potion";
                grandRedPotion.healthPoint = 50;
                MyHero.AddToInventory(grandRedPotion);
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("*You aquired " + grandRedPotion.name + ", it's now added to you inventory*"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadLine();
            }

            GameOver();

        }

        public static void GameTitel()
        {
            Console.Write(@"
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
            Console.Write(@"
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

        public static void GameOver()
        {
            Console.Write(@"
          _____                    _____                    _____                    _____                           _______                   _____                    _____                    _____          
         /\    \                  /\    \                  /\    \                  /\    \                         /::\    \                 /\    \                  /\    \                  /\    \         
        /::\    \                /::\    \                /::\____\                /::\    \                       /::::\    \               /::\____\                /::\    \                /::\    \        
       /::::\    \              /::::\    \              /::::|   |               /::::\    \                     /::::::\    \             /:::/    /               /::::\    \              /::::\    \       
      /::::::\    \            /::::::\    \            /:::::|   |              /::::::\    \                   /::::::::\    \           /:::/    /               /::::::\    \            /::::::\    \      
     /:::/\:::\    \          /:::/\:::\    \          /::::::|   |             /:::/\:::\    \                 /:::/~~\:::\    \         /:::/    /               /:::/\:::\    \          /:::/\:::\    \     
    /:::/  \:::\    \        /:::/__\:::\    \        /:::/|::|   |            /:::/__\:::\    \               /:::/    \:::\    \       /:::/____/               /:::/__\:::\    \        /:::/__\:::\    \    
   /:::/    \:::\    \      /::::\   \:::\    \      /:::/ |::|   |           /::::\   \:::\    \             /:::/    / \:::\    \      |::|    |               /::::\   \:::\    \      /::::\   \:::\    \   
  /:::/    / \:::\    \    /::::::\   \:::\    \    /:::/  |::|___|______    /::::::\   \:::\    \           /:::/____/   \:::\____\     |::|    |     _____    /::::::\   \:::\    \    /::::::\   \:::\    \  
 /:::/    /   \:::\ ___\  /:::/\:::\   \:::\    \  /:::/   |::::::::\    \  /:::/\:::\   \:::\    \         |:::|    |     |:::|    |    |::|    |    /\    \  /:::/\:::\   \:::\    \  /:::/\:::\   \:::\____\ 
/:::/____/  ___\:::|    |/:::/  \:::\   \:::\____\/:::/    |:::::::::\____\/:::/__\:::\   \:::\____\        |:::|____|     |:::|    |    |::|    |   /::\____\/:::/__\:::\   \:::\____\/:::/  \:::\   \:::|    |
\:::\    \ /\  /:::|____|\::/    \:::\  /:::/    /\::/    / ~~~~~/:::/    /\:::\   \:::\   \::/    /         \:::\    \   /:::/    /     |::|    |  /:::/    /\:::\   \:::\   \::/    /\::/   |::::\  /:::|____|
 \:::\    /::\ \::/    /  \/____/ \:::\/:::/    /  \/____/      /:::/    /  \:::\   \:::\   \/____/           \:::\    \ /:::/    /      |::|    | /:::/    /  \:::\   \:::\   \/____/  \/____|:::::\/:::/    / 
  \:::\   \:::\ \/____/            \::::::/    /               /:::/    /    \:::\   \:::\    \                \:::\    /:::/    /       |::|____|/:::/    /    \:::\   \:::\    \            |:::::::::/    /  
   \:::\   \:::\____\               \::::/    /               /:::/    /      \:::\   \:::\____\                \:::\__/:::/    /        |:::::::::::/    /      \:::\   \:::\____\           |::|\::::/    /   
    \:::\  /:::/    /               /:::/    /               /:::/    /        \:::\   \::/    /                 \::::::::/    /         \::::::::::/____/        \:::\   \::/    /           |::| \::/____/    
     \:::\/:::/    /               /:::/    /               /:::/    /          \:::\   \/____/                   \::::::/    /           ~~~~~~~~~~               \:::\   \/____/            |::|  ~|          
      \::::::/    /               /:::/    /               /:::/    /            \:::\    \                        \::::/    /                                      \:::\    \                |::|   |          
       \::::/    /               /:::/    /               /:::/    /              \:::\____\                        \::/____/                                        \:::\____\               \::|   |          
        \::/____/                \::/    /                \::/    /                \::/    /                         ~~                                               \::/    /                \:|   |          
                                  \/____/                  \/____/                  \/____/                                                                            \/____/                  \|___|          
                                                                                                                                                                                                                
");
        }
    }
}
