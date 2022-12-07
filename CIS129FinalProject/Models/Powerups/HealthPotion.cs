namespace CIS129FinalProject.Models.Powerups;

public class HealthPotion : PowerupAbstract
{
    public override string Name { get; set; } = "Health Potion";
    public override string Description { get; set; } = "A potion to restore some Health";
    public override int Effect { get; set; } = 10;
    public override string EffectDescription { get; set; } = "Restores 10 HP";
    
    public override void PerformActionAgainstPlayer(PlayerAbstract playerTargeted)
    {
        Console.WriteLine($"{Name} was used!");
        Console.WriteLine($"{Description}");
        Console.WriteLine($"{EffectDescription}");

        playerTargeted.Hp += Effect;
        Console.WriteLine($"{playerTargeted.Name} now has {playerTargeted.Hp} health and {playerTargeted.Mp} magicka.");
    }
}