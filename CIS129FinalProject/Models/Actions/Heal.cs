using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models.Actions;

public class Heal : ActionAbstract
{
    public override string Name { get; set; } = "Heal";
    public override int MpCost { get; set; } = 5;
    public override string Description { get; set; } = "The Wizert casts a spell to heal his wounds.";
    public override string EffectDescription { get; set; } = "Heals 3 Health Points (aka HP).";
    public override int EffectResult { get; set; } = 3;
}