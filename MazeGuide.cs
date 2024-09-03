using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class MazeGuide
    {
        public void DisplayWelcomeMessage()
        {
            Console.Clear();
            string welcomeMessage = @"
                                                  _                            _                             
                                                 | |                          | |                            
                                    __      _____| | ___ ___  _ __ ___   ___  | |_ ___                       
                                    \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \                      
                                     \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |                     
                                      \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/                      
                                                                                                             
                                                                                                             
                                     _ _                                                                 _ _ 
                                    ( | )                                                               ( | )
                                     V V   _ __ ___   ___  _____      __  _ __ ___   ___  _____      __  V V 
                                          | '_ ` _ \ / _ \/ _ \ \ /\ / / | '_ ` _ \ / _ \/ _ \ \ /\ / /      
                                          | | | | | |  __/ (_) \ V  V /  | | | | | |  __/ (_) \ V  V /       
                                          |_| |_| |_|\___|\___/ \_/\_/   |_| |_| |_|\___|\___/ \_/\_/        
                                                                                                             
                                                                                                             
                                                                                                             
                                                                                                             
                                     _ __ ___   __ _ _______    __ _ _ __ ___   __ _  ___                    
                                    | '_ ` _ \ / _` |_  / _ \  / _` | '_ ` _ \ / _` |/ _ \                   
                                    | | | | | | (_| |/ /  __/ | (_| | | | | | | (_| |  __/                   
                                    |_| |_| |_|\__,_/___\___|  \__, |_| |_| |_|\__,_|\___|                   
                                                                __/ |                                        
                                                               |___/                                         ";


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(welcomeMessage);
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();


            string storyMessage = @"
You were on your way home after buying some candy when you noticed a cat with small kittens who seemed hungry.
Then you saw the mother cat walking down a path as if looking for something. Your curiosity led you to follow her
and now you find yourself in a maze. Can you reach the end?";


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(storyMessage);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Press any key to start..");
            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();
        }

        public void DisplayEndMessage()
        {
            Console.Clear();
            string endMessage = @"
                                     _____                 _     _       _     _                       
                                    |  __ \               | |   (_)     | |   | |                      
                                    | |  \/ ___   ___   __| |    _  ___ | |__ | |                      
                                    | | __ / _ \ / _ \ / _` |   | |/ _ \| '_ \| |                      
                                    | |_\ \ (_) | (_) | (_| |   | | (_) | |_) |_|                      
                                     \____/\___/ \___/ \__,_|   | |\___/|_.__/(_)                      
                                                               _/ |                                    
                                                              |__/                                     
                                                         _                                           _ 
                                                        | |                                         | |
                                     _   _  ___  _   _  | |__   __ ___   _____  __      _____  _ __ | |
                                    | | | |/ _ \| | | | | '_ \ / _` \ \ / / _ \ \ \ /\ / / _ \| '_ \| |
                                    | |_| | (_) | |_| | | | | | (_| |\ V /  __/  \ V  V / (_) | | | |_|
                                     \__, |\___/ \__,_| |_| |_|\__,_| \_/ \___|   \_/\_/ \___/|_| |_(_)
                                      __/ |                                                            
                                     |___/                                                             
";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(endMessage);
            Thread.Sleep(3000);
            Console.Clear();


            string endMessage2 = @"You've found a bottle of milk that you can give to the cat and her hungry kittens.";

            Console.WriteLine(endMessage2);
            Console.WriteLine("Press any key to exist..");
            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();
        }
    }
}
