namespace CIS129FinalProject.Models.Actions;

public class EmptyAction : ActionAbstract
{
    public override string Name { get; set; } = "No Action";
    public override int MpCost { get; set; } = 0;
    public override string Description { get; set; } = "No Action";
    public override string EffectDescription { get; set; } = "No Action";
    public override int EffectResult { get; set; } = 0;
}