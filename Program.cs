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

List<Enemy> AllEnemies = new List<Enemy>()
{
    Villian
};

foreach(Attack a in AllAttacks)
{
    a.ShowInfo();
}

foreach(Enemy e in AllEnemies)
{
    e.ShowInfo();
    e.RandomAttack();
}