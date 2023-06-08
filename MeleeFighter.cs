public class Melee : Enemy
{
    // public string Name {get; set;}
    // public int Health {get; set;}
    // public int DamageAmount {get; set;}
    // public List<Melee> MeleeAttackList = new List<Melee>();
    public Melee(string name, List<Attack> attackList) : base(name, attackList, 120)
    {
    
    }
    
    public void Kaiokenx100(Enemy Target)
    {
        Random rand = new Random();
        int entropy = rand.Next(0, AttackList.Count);
        AttackList[entropy].DamageAmount += 10;
        PerformAttack(Target, AttackList[entropy]);
        AttackList[entropy].DamageAmount -=10;
    }
}