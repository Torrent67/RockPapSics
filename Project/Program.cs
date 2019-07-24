using System;
using System.Collections.Generic;

namespace GameLog
{
    class Game
    {
        public static void Main()
        {   
            MainProg lol = new MainProg();
            Console.WriteLine("Enter Rock, Paper, or Scissors");
            string userChoice = Console.ReadLine();
            if(userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors")
            {   string outcome = lol.OutCome(userChoice);
                 Console.WriteLine("Results " + outcome);
            }
            // Console.WriteLine(lol.OutCome());
           
          
        

        }
    }
}