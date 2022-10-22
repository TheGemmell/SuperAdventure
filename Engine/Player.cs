using System.Collections.Generic;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int exp, int level=1, int gold=25 ) 
            : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            Exp = exp;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
