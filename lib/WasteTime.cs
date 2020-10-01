using System;

    namespace hackathon{
    class WasteTime : IWork
    {
        public string Name {get;set;}
        public int Minutes {get;set;}
        public bool IsClerical {get;set;}
        public bool IsTechnical {get;set;}
        public string GetInfo()
        {
            return $"{Name} (WasteTime).  Minutes: {Minutes}.  Clerical?: {IsClerical}, Technical?: {IsTechnical}";
        }
        public WasteTime(string name, int minutes, bool clerical, bool technical)
        {
            Name = name;
            Minutes = minutes;
            IsClerical = clerical;
            IsTechnical = technical;
        }
    }  
}