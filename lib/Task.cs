using System;

    namespace hackathon{
    class Task : IWork
    {
        public string Name {get;set;}
        public int Minutes {get;set;}
        public bool IsClerical {get;set;}
        public bool IsTechnical {get;set;}
        public string GetInfo()
        {
            return $"{Name} (Task).  Minutes: {Minutes}.  Clerical?: {IsClerical}, Sweet?: {IsTechnical}";
        }
        public Task(string name, int minutes, bool clerical, bool technical)
        {
            Name = name;
            Minutes = minutes;
            IsClerical = clerical;
            IsTechnical = technical;
        }
    }  
}