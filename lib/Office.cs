using System;
using System.Collections.Generic;

namespace hackathon{
    class Office
    {
        public List<IWork> Work;
        public Office()
        {
            Work = new List<IWork>()
            {
                new Task("went to meeting", 60, false, false),
                new Task("filed TPS Reports", 45, true, false),
                new Task("fixed a bug", 30, false, true), 
                new WasteTime("got coffee", 20, false, false),
                new WasteTime("visited watercooler", 15, false, false),
                new WasteTime("commented on Reddit", 20, false, false),
                new Task("wrote documentation", 60, true, false),
                new Task("attempted to print stuff, yelled at printer.", 120, true, true),
                new WasteTime("created build", 60, false, true),
                new Task("did competitive research", 60, true, false),
                new Task("played solitaire", 75, false, false), 
                new Task("trained newbs", 100, false, false), 
            };  
        }
        public IWork DoJob()
        {
            var rand = new Random();
            return Work[rand.Next(Work.Count)];
        }
    }
}