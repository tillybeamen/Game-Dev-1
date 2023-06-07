public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Attack> AttackList = new List<Attack>();

    public Enemy(string name, List<Attack> attackList, int health)
    {
        Name = name;
        Health = 100;
        AttackList = attackList;
    }

    public void RandomAttack()
    {

        Random rand = new Random();
        int entropy = rand.Next(0, AttackList.Count);
        System.Console.WriteLine($"{AttackList[entropy].Name}");

        // System.Console.WriteLine();
    }

    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Enemy Name: {Name}");
        System.Console.WriteLine($"Enemy Health: {Health}");
        System.Console.WriteLine($"Attack Name: {AttackList}");
    }

}
