namespace CIS129FinalProject.Models.Actions;

public abstract class ActionAbstract
{
    public abstract string Name { get; set; }
    
    public abstract int MpCost { get; set; }

    public abstract string Description { get; set; } 

    public abstract string EffectDescription { get; set; } 

    public abstract int EffectResult { get; set; }
    
}