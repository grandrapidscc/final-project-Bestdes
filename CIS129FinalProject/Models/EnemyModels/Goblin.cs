namespace CIS129FinalProject.Models.EnemyModels;

public class Goblin : EnemyAbstract
{
    public override string Name { get; set; } = "Goblin";
    public override int HealthPoints { get; set; } = 3;
    public override string AttackName { get; set; } = "Body Slam";
    public override int AttackDamage { get; set; } = 2;
}