namespace CIS129FinalProject.Models.Powerups;

public class HealthPotion : PowerupAbstract
{
    public override string Name { get; set; }
    public override string Description { get; set; }
    public override int Effect { get; set; }
    public override string EffectDescription { get; set; }
}