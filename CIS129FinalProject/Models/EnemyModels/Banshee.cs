namespace CIS129FinalProject.Models.EnemyModels;

public class Banshee : EnemyAbstract
{
    public override string Name { get; set; } = "Banshee";
    public override int HealthPoints { get; set; } = 8;
    public override string AttackName { get; set; } = "Screech";
    public override int AttackDamage { get; set; } = 5;
    
}