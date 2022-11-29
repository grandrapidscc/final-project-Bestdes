using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models.Actions;

public class Heal : ActionAbstract, IAction
{
    public override string Name { get; set; }
    public override int MpCost { get; set; }
    public override string Description { get; set; }
    public override string EffectDescription { get; set; }
    public override int EffectResult { get; set; }
    public void PerformAction()
    {
        throw new NotImplementedException();
    }
}