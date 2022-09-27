namespace Engine
{
    public class HealingPotion : Item
    {
        public int HealAmount { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            HealAmount = amountToHeal;
        }
    }
}
