using CIS129FinalProject.Interfaces;

namespace CIS129FinalProject.Models.EnemyModels;

public abstract class EnemyAbstract : IEnemyAction
{
    public abstract string Name { get; set; }
    public abstract int HealthPoints { get; set; }
    public abstract string AttackName { get; set; }
    public abstract int AttackDamage { get; set; }

    public void PerformActionAgainstPlayer(PlayerAbstract playerTargeted)
    {
        Console.WriteLine($"{AttackName} was used!");
        Console.WriteLine($"{AttackName} caused {AttackDamage} to {playerTargeted.Name}");
        Console.WriteLine($"{playerTargeted.Name} has {playerTargeted.HP} {nameof(playerTargeted.HP)} left!");

        playerTargeted.HP -= AttackDamage;
    }
}