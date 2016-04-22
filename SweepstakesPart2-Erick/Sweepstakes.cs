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

            //else if (choice == "2")

            //{

            //    sodaMenu();

            //}


            else

            {
                Console.WriteLine("That is not a valid option in this menu.");
                //runMenu();
            }

        }

        public void createContestants()
        {
            Console.WriteLine("Enter contestants name.");
            string name = Console.ReadLine();
            int ticketNumber = sweeps.Count;
            Contestant newContestant = new Contestant(name, ticketNumber);
            RegisterContestant(newContestant);
            runMenu();


        }

   
        public void RegisterContestant(Contestant contestant)
        {
     
            sweeps.Add(contestant.ticketNumber, contestant);
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