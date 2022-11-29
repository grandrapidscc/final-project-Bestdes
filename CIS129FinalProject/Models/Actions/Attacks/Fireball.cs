using CIS129FinalProject.Interfaces;

namespace CIS129FinalProject.Models.Actions.Attacks;

public class Fireball : ActionAbstract, IAction
{
    public override string Name { get; set; } = "Fireball";

    public override int MpCost { get; set; } = 3;

    public override string Description { get; set; } = "The Wizert casts a fireball that burns the enemy";

    public override string EffectDescription { get; set; } = "Does 5 Damage";

    public override int EffectResult { get; set; } = 5;

    public void PerformAction()
    {
        throw new NotImplementedException();
    }
}