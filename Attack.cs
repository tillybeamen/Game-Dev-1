public class Attack
{
    public string Name {get; set;}
    public int DamageAmount {get; set;}
    public Attack(string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
    }

    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Attack Name: {Name}");
        System.Console.WriteLine($"Dmg Ammount: {DamageAmount}");
    }
}
