namespace CIS129FinalProject.Models.EnemyModels;

public class Banshee : EnemyAbstract 
{
    public override string Name { get; set; }
    public override int HealthPoints { get; set; }

    public Banshee(string name, int healthPoints)
    {
        Name = name;
        HealthPoints = healthPoints;
    }
}