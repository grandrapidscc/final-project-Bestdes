using CIS129FinalProject.Interfaces;

namespace CIS129FinalProject.Models.Actions.Attacks;

public abstract class ActionAbstract : IAction
{
    public abstract string Name { get; set; }
    
    public abstract int MpCost { get; set; }

    public abstract string Description { get; set; } 

    public abstract string EffectDescription { get; set; } 

    public abstract int EffectResult { get; set; }
    
    public void PerformAction()
    {
        throw new NotImplementedException();
    }

    
}