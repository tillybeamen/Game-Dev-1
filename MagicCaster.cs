public class Magic : Enemy
{
    // public int DamageAmount {get; set;}
    // public List<Magic> RangedAttackList = new List<Magic>();
    // , List<Magic> rangedAttackList
    public Magic(string name, List<Attack> attackList) : base(name, attackList, 80)
    {
           // RangedAttackList = rangedAttackList;
    }
    
    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        System.Console.WriteLine($"{Target.Name}'s health is {Target.Health}");
        // Fighter heals a targeted enemy for 40 health
        // and displays the new health at the end
    }
}