namespace CIS129FinalProject.Models.Powerups;

public abstract class PowerupAbstract
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract int Effect { get; set; }
    public abstract string EffectDescription { get; set; }
}