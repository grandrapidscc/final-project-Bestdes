namespace CIS129FinalProject.Models.EnemyModels;

public class Goblin : EnemyAbstract 
{
    public override string Name { get; set; }
    public override int HealthPoints { get; set; }

    public Goblin(string name, int healthPoints)
    {
        Name = name;
        HealthPoints = healthPoints;
    }
}