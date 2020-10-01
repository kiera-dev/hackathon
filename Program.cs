using System;

namespace hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player 1 name:");
            string name = Console.ReadLine();
            Console.WriteLine("Select an office supply:");
            Console.WriteLine(" 1  Stapler: -10min to time worked ");
            Console.WriteLine(" 2  Sticky Notes: + 10min to time wasted");
            Console.WriteLine(" 3  Highlighter: -5min to time worked, +5 min to time wasted");
            Console.WriteLine("Enter number (1, 2, or 3) to choose!");
            int supply = Convert.ToInt32(Console.ReadLine());
            Engineer player1 = new Engineer(name, supply);

            Console.WriteLine("Enter player 2 name:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Select an office supply:");
            Console.WriteLine(" 1  Stapler: -10min to time worked ");
            Console.WriteLine(" 2  Sticky Notes: + 10min to time wasted");
            Console.WriteLine(" 3  Highlighter: -5min to time worked, +5 min to time wasted");
            Console.WriteLine("Enter number (1, 2, or 3) to choose!");
            int supply2 = Convert.ToInt32(Console.ReadLine());
            Manager player2 = new Manager(name2, supply2);

            Console.WriteLine("Enter player 3 name:");
            string name3 = Console.ReadLine();
            Console.WriteLine("Select an office supply:");
            Console.WriteLine(" 1  Stapler: -10min to time worked ");
            Console.WriteLine(" 2  Sticky Notes: + 10min to time wasted");
            Console.WriteLine(" 3  Highlighter: -5min to time worked, +5 min to time wasted");
            Console.WriteLine("Enter number (1, 2, or 3) to choose!");
            int supply3 = Convert.ToInt32(Console.ReadLine());
            Newb player3 = new Newb(name3, supply3);

            Office office = new Office(); 
            Console.WriteLine($" Looks like someone's got a case of the Mondays....");
            while(player1.IsDone == false)
            {
                player1.Work(office.DoJob());
            }
            while(player2.IsDone == false)
            {
                player2.Work(office.DoJob());
            }
            while(player3.IsDone == false)
            {
                player3.Work(office.DoJob());
            }
            Console.WriteLine($" Engineer {player1.Name} did {player1.JobHistory.Count} things and wasted {player1.timeWasted} minutes.");
            Console.WriteLine($" Manager {player2.Name} did {player2.JobHistory.Count} things and wasted {player2.timeWasted} minutes.");
            Console.WriteLine($" Newb {player3.Name} did {player3.JobHistory.Count} things and wasted {player3.timeWasted} minutes.");
            if(player1.timeWasted > player2.timeWasted)
                {
                    if(player1.timeWasted > player3.timeWasted){
                    Console.WriteLine($"{player1.Name} beat their case of the Mondays and wasted the most time!!");
                    }
                    else{
                        Console.WriteLine($"{player3.Name} beat their case of the Mondays and wasted the most time!!");
                    }
                }
            else if(player1.timeWasted < player2.timeWasted)
                {
                    if(player3.timeWasted < player2.timeWasted)
                    {
                    Console.WriteLine($"{player2.Name} beat their case of the Mondays and wasted the most time!!");
                    }
                    else 
                    {
                        Console.WriteLine($"{player3.Name} beat their case of the Mondays and wasted the most time!!");
                    }
                }
            else
                {
                    Console.WriteLine("Something Happened! PLayers need to come in on Saturday. Everyone loses :P");
                }
        }
    }
}
