using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models.Actions.Movement;

public class MoveStandard : ActionAbstract, IAction
{
    public (int, int) mCurrentPosition;
    
    public override string Name { get; set; }
    public override int MpCost { get; set; }
    public override string Description { get; set; }
    public override string EffectDescription { get; set; }
    public override int EffectResult { get; set; }

    public void PerformAction()
    {
        throw new NotImplementedException();
    }
    
    private void PerformMovement(MovementDirection movementDirection)
    {
        switch (movementDirection)
        {
            case MovementDirection.East:
                MoveEast();
                break;
            case MovementDirection.North:
                MoveNorth();
                break;
            case MovementDirection.South:
                MoveSouth();
                break;
            case MovementDirection.West:
                MoveWest();
                break;
        }
    }

    private void MoveEast()
    {
        mCurrentPosition = (mCurrentPosition.Item1 + 1, mCurrentPosition.Item2);
    }
    
    private void MoveNorth()
    {
        mCurrentPosition = (mCurrentPosition.Item1, mCurrentPosition.Item2 + 1);
    }
    
    private void MoveSouth()
    {
        mCurrentPosition = (mCurrentPosition.Item1, mCurrentPosition.Item2 - 1);
    }
    
    private void MoveWest()
    {
        mCurrentPosition = (mCurrentPosition.Item1 - 1, mCurrentPosition.Item2);
    }
    
    public void ValidateMovement() {}
    
}