namespace CIS129FinalProject.Models.EnemyModels;

public class Orc : EnemyAbstract
{
    public override string Name { get; set; } = "Orc";
    public override int HealthPoints { get; set; } = 5;
    public override string AttackName { get; set; } = "Cleave";
    public override int AttackDamage { get; set; } = 3;
}