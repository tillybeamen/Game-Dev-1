using System.Xml.Schema;
using Microsoft.Win32.SafeHandles;
Attack Physical = new Attack("Kunai", 8);
Attack Jutsu = new Attack("Kage Bunshin", 12);
Attack Magic = new Attack("Avada Kedavra", 25);

List<Attack> AllAttacks = new List<Attack>()
{

Physical,
Jutsu,
Magic
};
Enemy Villian = new Enemy("Handsome Jack", AllAttacks, 100);
Villian.AttackList.Add(Physical);
Villian.AttackList.Add(Jutsu);
Villian.AttackList.Add(Magic);

Enemy Villian_2 = new Enemy("Orochimaru", AllAttacks, 100);
Villian_2.AttackList.Add(Physical);
Villian_2.AttackList.Add(Jutsu);
Villian_2.AttackList.Add(Magic);

List<Enemy> AllEnemies = new List<Enemy>()
{
    Villian
};

Attack Punch = new Attack("Serious Punch", 20);
Attack Kick = new Attack("Tornado Kick", 15);
Attack Tackle = new Attack("Earthquake", 25);

List<Attack> AllMeleeAttacks = new List<Attack>()
{
    Punch,
    Kick,
    Tackle
};

Attack Gun = new Attack("Galick Gun", 20);
Attack  Projectile = new Attack("Sonic Boom", 15);

List<Attack> AllRangedAttacks = new List<Attack>()
{
    Gun,
    Projectile
};

Attack Wand_1 = new Attack("Petrificus Totalis", 25);
Attack Wand_2 = new Attack("Confringo", 20);
Attack Wand_3 = new Attack("Crucio", 10);

List<Attack> AllMagicAttacks = new List<Attack>()
{
    Wand_1,
    Wand_2,
    Wand_3
};

Villian.RandomAttack(Villian.AttackList);
Villian.PerformAttack(Villian_2, Villian.AttackList[1]);




Ranged Saiyan = new Ranged("Vegeta", AllRangedAttacks, 5);
Saiyan.RangedAttack(Villian, Saiyan.AttackList[0]);
Saiyan.RangedAttack(Villian, Saiyan.AttackList[1]);
Saiyan.Dash();
Saiyan.RangedAttack(Villian, Saiyan.AttackList[1]);


Melee Brute = new Melee("Saitama", AllMeleeAttacks);
Brute.Kaiokenx100(Villian_2);
Brute.PerformAttack(Villian_2, Brute.AttackList[0]);
Brute.PerformAttack(Villian_2, Brute.AttackList[1]);
Brute.PerformAttack(Villian_2, Brute.AttackList[2]);

Magic Wizard = new Magic("Voldemort", AllMagicAttacks);
Wizard.PerformAttack(Villian, Wizard.AttackList[0]);
Wizard.PerformAttack(Villian, Wizard.AttackList[1]);
Wizard.PerformAttack(Villian, Wizard.AttackList[2]);
Wizard.Heal(Villian);
Saiyan.RangedAttack(Brute, Saiyan.AttackList[1]);
Wizard.Heal(Wizard);


