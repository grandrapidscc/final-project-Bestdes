using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models.Actions.Movement;

public class MoveStandard : ActionAbstract
{
    public override string Name { get; set; } = "Move";
    public override int MpCost { get; set; } = 0;
    public override string Description { get; set; } = "Moving";
    public override string EffectDescription { get; set; } = "Moved to a new space!";
    public override int EffectResult { get; set; } = 0;

    public (int, int) PerformMove(MovementDirection movementDirection, (int, int) currentPosition)
    {
        switch (movementDirection)
        {
            case MovementDirection.East:
                return MoveEast(currentPosition);
            case MovementDirection.North:
                return MoveNorth(currentPosition);
            case MovementDirection.South:
                return MoveSouth(currentPosition);
            case MovementDirection.West:
                return MoveWest(currentPosition);
        }

        return (0, 0);
    }

    private (int, int) MoveEast((int, int) currentPostion)
    {
        return currentPostion = (currentPostion.Item1 + 1, currentPostion.Item2);
    }
    
    private (int, int) MoveNorth((int, int) currentPostion)
    {
        return currentPostion = (currentPostion.Item1, currentPostion.Item2 + 1);
    }
    
    private (int, int) MoveSouth((int, int) currentPostion)
    {
        return currentPostion = (currentPostion.Item1, currentPostion.Item2 - 1);
    }
    
    private (int, int) MoveWest((int, int) currentPostion)
    {
        return currentPostion = (currentPostion.Item1 - 1, currentPostion.Item2);
    }
}