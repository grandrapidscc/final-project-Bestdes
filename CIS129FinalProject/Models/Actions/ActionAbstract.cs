using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.EnemyModels;

namespace CIS129FinalProject.Models.Actions;

public abstract class ActionAbstract : IAction
{
    public abstract string Name { get; set; }
    public abstract int MpCost { get; set; }
    public abstract string Description { get; set; }
    public abstract string EffectDescription { get; set; }
    public abstract int EffectResult { get; set; }

    public virtual void PerformAction()
    {
        Console.WriteLine($"{Name} was performed!");
        Console.WriteLine($"{Description}");
        Console.WriteLine($"Consumed {MpCost} MP!");
        Console.WriteLine($"{EffectDescription}");
    }

    public virtual void PerformActionAgainstEnemy(EnemyAbstract enemyTargeted, PlayerAbstract player)
    {
        Console.WriteLine($"{Name} was performed!");
        Console.WriteLine($"{Description}");
        Console.WriteLine($"Consumed {MpCost} MP!");
        Console.WriteLine($"{EffectDescription}");
        
        enemyTargeted.HealthPoints -= EffectResult;
        player.MP -= MpCost;
        
        Console.WriteLine($"The {enemyTargeted.Name}'s {nameof(enemyTargeted.HealthPoints)} are now at {enemyTargeted.HealthPoints}!");
    }

    public virtual void PerformActionAgainstPlayer(PlayerAbstract playerTargeted)
    {
        Console.WriteLine($"{Name} was performed!");
        Console.WriteLine($"{Description}");
        Console.WriteLine($"Consumed {MpCost} MP!");
        Console.WriteLine($"{EffectDescription}");
        
        playerTargeted.MP -= MpCost;
        playerTargeted.HP += EffectResult;
    }
}