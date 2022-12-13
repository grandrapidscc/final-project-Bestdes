namespace CIS129FinalProject.Models.Powerups;

public class MagickaPotion : PowerupAbstract
{
    public override string Name { get; set; } = "Magicka Potion";
    public override string Description { get; set; } = "A potion to restore magicka";
    public override int Effect { get; set; } = 20;
    public override string EffectDescription { get; set; } = "Restores 20 MP";
    
    public override void PerformActionAgainstPlayer(PlayerAbstract playerTargeted)
    {
        Console.WriteLine($"{Name} was used!");
        Console.WriteLine($"{Description}");
        Console.WriteLine($"{EffectDescription}");

        playerTargeted.Mp += Effect;
        Console.WriteLine($"{playerTargeted.Name} now has {playerTargeted.Hp} health and {playerTargeted.Mp} magicka.");
    }
}