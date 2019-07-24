using System;
using System.Collections.Generic;

namespace GameLog
{
    public class MainProg
    {
        public string UserChoice;
        public string RandChoice;
        public int Number;
        string[] choices = new string[] {"Rock", "Paper", "Scissors"};

        public string OutCome(string userChoice)
        {
            UserChoice = userChoice;
            
            

            Random computer = new Random();
            int number = computer.Next(0, 3);
            RandChoice = choices[number];
            Console.WriteLine("The computer chooses " + RandChoice);
            if(UserChoice == "Rock" && RandChoice == "Paper" || UserChoice == "Paper" && RandChoice == "Rock")
            {
                return "Paper wins";
            }
            else if(UserChoice == "Paper" && RandChoice == "Scissors" || UserChoice == "Scissors" && RandChoice == "Paper")
            {
                return "Scissors wins";
            }
            else if(UserChoice == "Scissors" && RandChoice == "Rock" || UserChoice == "Rock" && RandChoice == "Scissors")
            {
                return "Rock wins";
            }
            else if (UserChoice == "Rock" && RandChoice == "Rock" || UserChoice == "Paper" && RandChoice == "Paper" || UserChoice == "Scissors" && RandChoice == "Scissors")
            {
                return "Tie Game";
            }
            else
            {
                return "";
            }
        }
    }
}

// if u= r && c=s || u= s && c= p || u = p && c = r) 
// return you win
