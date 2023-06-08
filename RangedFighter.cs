public class Ranged : Enemy
{
    // public string Name {get; set;}
    // public int Health {get; set;}
    // public int DamageAmount {get; set;}
    public int Distance {get;set;}
    // public List<Ranged> RangedAttackList = new List<Ranged>();
    // , List<Ranged> rangedAttackList
    public Ranged(string name, List<Attack> attackList, int distance) : base(name, attackList, 90)
    {
        Distance = 5; // if distance is less than 10 cannot attack
        // RangedAttackList = rangedAttackList;
    }
    
    public void RangedAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance<10)
        {
            Target.Health = Target.Health - ChosenAttack.DamageAmount;
            System.Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!!");
        }
        else
        {
            System.Console.WriteLine($"{Name} was too far away from {Target.Name} to attack.");
        }
    }
    public int Dash()
    {
        return Distance = 20;
    }
}