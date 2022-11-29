namespace CIS129FinalProject.Models.EnemyModels;

public class Orc : EnemyAbstract 
{
    public override string Name { get; set; }
    public override int HealthPoints { get; set; }

    public Orc(string name, int healthPoints)
    {
        Name = name;
        HealthPoints = healthPoints;
    }
}