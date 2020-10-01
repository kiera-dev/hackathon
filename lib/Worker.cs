using System;
using System.Collections.Generic;

namespace hackathon{
    abstract class Worker
    {
        protected int minutesWorked;
        protected internal int timeWasted;
        public string Name;
        public bool DrankCoffee;
        public int OfficeSupply;
        public List<IWork> JobHistory;
        public Worker(string name, int supply)
        {
            minutesWorked = 0;
            JobHistory = new List<IWork>();
            Name = name;
            DrankCoffee = false;
            timeWasted = 0;
            OfficeSupply = supply;

        }
        public Worker(string name)
        {
            minutesWorked = 0;
            JobHistory = new List<IWork>();
            Name = name;
            DrankCoffee = false;
            timeWasted = 0;
            OfficeSupply = 3;

        }
        
        public abstract bool IsDone {get;}
        
        public abstract void Work(IWork item);
    }  
}