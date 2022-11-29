namespace CIS129FinalProject.Models.Stages;

public abstract class StageAbstract
{
    public abstract string Name { get; }
    public abstract (int, int)[] CoordinateSpace { get; set; }
    public abstract (int, int) PlayerPosition { get; set; }
}