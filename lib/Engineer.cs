using System;
using System.Collections.Generic;

namespace hackathon{
    class Engineer: Worker
    {
        public Engineer (string name, int supply) : base (name, supply) 
        {
            Name = name;
            OfficeSupply = supply;
        }
        
        public override bool IsDone
        {
             get 
             { 
                 if(minutesWorked >= 480)
                 {
                     bool done = true;
                     return done;
                 }
                 else{
                     bool done = false;
                     return done;
                 } 
             }
        }
        // provide override for IsFull (Full at 1200 Calories)
        
        public override void Work(IWork item)
        {
            if (this.IsDone == false)
            {
                this.minutesWorked += item.Minutes;
                
                JobHistory.Add(item);
                Console.WriteLine($"Engineer {item.Name}!");
                if (item is WasteTime)
                {
                    this.timeWasted +=item.Minutes;
                }
                if (item.Name == "got coffee")
                {
                    DrankCoffee = true;
                }
                if(DrankCoffee == true)
                {
                    this.minutesWorked -= 10;
                }
                if(item.IsClerical == true)
                {
                    this.minutesWorked += 10;
                    // Console.WriteLine($"{item.Name} was clerical!");
                }
                if(item.IsTechnical == true)
                {
                //   Console.WriteLine($"{item.Name} was technical!");
                    this.minutesWorked -= 20;
                }
                if(OfficeSupply == 1)
                {
                    this.minutesWorked -=10;
                }
                if(OfficeSupply == 2)
                {
                    this.timeWasted += 10;
                }
                if(OfficeSupply ==3)
                {
                    this.timeWasted +=5;
                    this.minutesWorked -=5;
                }
            }
            else
            {
                Console.WriteLine($"Cannot do {item.Name}, it's time to go home!!");
            }
        }
    }
}