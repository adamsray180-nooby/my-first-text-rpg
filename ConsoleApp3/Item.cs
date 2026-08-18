
namespace ConsoleApp3
{
    internal class Item
    {
        public string Name {  get; set; }
        public string Description { get; set; }

        public int HealAmount { get; set; }

        public Item(string name, string description, int healAmount)
        {
            Name = name;
            Description = description;
            HealAmount = healAmount;
        }

    }
}
