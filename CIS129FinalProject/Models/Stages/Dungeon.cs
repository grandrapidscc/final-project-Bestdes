namespace CIS129FinalProject.Models.Stages;

public class Dungeon
{
    public string Name { get; }
    public (int, int)[] CoordinateSpace { get; }
    public (int, int) PlayerPosition { get; set; }
}