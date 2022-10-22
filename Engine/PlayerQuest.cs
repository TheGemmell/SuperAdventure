namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsStarted { get; set; }
        
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
            IsStarted = false;
        }
    }
}