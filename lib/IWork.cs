namespace hackathon{
    interface IWork
    {
        string Name {get;set;}
        int Minutes {get;set;}
        bool IsClerical {get;set;}
        bool IsTechnical {get;set;}
        string GetInfo();
    }   
}