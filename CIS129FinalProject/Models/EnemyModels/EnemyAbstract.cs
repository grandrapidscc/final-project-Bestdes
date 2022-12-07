using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Models.EnemyModels;

public abstract class EnemyAbstract : SpaceEventEntity,IEnemyAction
{
    public abstract string Name { get; set; }
    public abstract int HealthPoints { get; set; }
    public abstract string AttackName { get; set; }
    public abstract int AttackDamage { get; set; }

    public void PerformActionAgainstPlayer(PlayerAbstract playerTargeted)
    {
        Console.WriteLine($"{AttackName} was used!");
        Console.WriteLine($"{AttackName} caused {AttackDamage} damage to {playerTargeted.Name}");
        Console.WriteLine($"{playerTargeted.Name} has {playerTargeted.Hp} {nameof(playerTargeted.Hp)} left!");

        playerTargeted.Hp -= AttackDamage;
    }
}