using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesPart2_Erick
{
    class Sweepstakes
    {
        public string gameName;
        Dictionary<int, Contestant> sweeps = new Dictionary<int, Contestant>();
        public int winningNumber;

        public Sweepstakes(string GameName)
        {
            gameName = GameName;
        }

        public void runMenu()
        {
            Console.WriteLine("Press 1 to enter contestants, press 2 begin raffle.");
            string choice = Console.ReadLine().ToLower();
            if (choice == "1")
            {
                createContestants();
            }

            else if (choice == "2")


            {

                PickWinner();

            }


            else

            {
                Console.WriteLine("That is not a valid option in this menu.");
                runMenu();
            }

        }

        public void createContestants()
        {
            Console.WriteLine("Enter contestants name.");
            string name = Console.ReadLine();
            int ticketNumber = sweeps.Count;
            Contestant newContestant = new Contestant(name, ticketNumber);
            Console.WriteLine("Your ticket number is " + ticketNumber);
            RegisterContestant(newContestant);
            runMenu();
        }


        public void RegisterContestant(Contestant contestant)
        {
            
            sweeps.Add(contestant.ticketNumber, contestant);
        }

        public int pickWinningNumber()
        {

            Random random = new Random();
            winningNumber = random.Next(0, sweeps.Count);
            Console.WriteLine("The winning number is " + winningNumber);
            return winningNumber;
        }

        public string PickWinner()
        {
            pickWinningNumber();
            Contestant winner = null;
            for (int i = 0; i < sweeps.Count; i++)
            {

                if (sweeps[i].ticketNumber == winningNumber)
                {
                    winner = sweeps[i];
                }

            }
            Console.WriteLine("The winner is " + winner.name);
            return winner.name;
        }
    }
}


//Using a Systems.Collections.Generic.Dictionary as an underlying structure, create a Sweepstakes class with the following functions(you will need to define a Contestant class containing appropriate fields for the purpose):
//    Sweepstakes(string name)
//    void RegisterContestant(Contestant contestant)
//    string PickWinner()
//    void PrintContestantInfo(Contestant contestant)
//Create a sweepstakes management system:
//    Write an ISweepstakesManager interface with the following custom functions:
//        void InsertSweepstakes(Sweepstakes sweepstakes)
//        Sweepstakes GetNextSweepstakesWinner()
//    Inherit from the ISweepstakesManager interface to implement the following subclasses:
//        SweepstakesStackManager(using System.Collections.Generic.Stack)
//        SweepstakesQueueManager(using System.Collections.Generic.Queue)