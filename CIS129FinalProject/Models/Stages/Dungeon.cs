namespace CIS129FinalProject.Models.Stages;

public class Dungeon : StageAbstract
{
    public override string Name { get; }
    public override (int, int)[] CoordinateSpace { get; set; }
    public override (int, int) PlayerPosition { get; set; }
    public override Dictionary<(int, int), SpaceEvent> EventDictionary { get; set; }
}