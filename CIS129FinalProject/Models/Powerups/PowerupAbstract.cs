using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Models.Powerups;

public abstract class PowerupAbstract : SpaceEventEntity, IActionAgainstPlayer
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract int Effect { get; set; }
    public abstract string EffectDescription { get; set; }

    public virtual void PerformActionAgainstPlayer(PlayerAbstract playerTargeted)
    {
        Console.WriteLine($"{Name} was used!");
        Console.WriteLine($"{Description}");
        Console.WriteLine($"{EffectDescription}");
        
        Console.WriteLine($"{playerTargeted.Name} now has {playerTargeted.Hp} health and {playerTargeted.Mp} magicka.");
    }
}