using CIS129FinalProject.Models;
using CIS129FinalProject.Models.Actions.Movement;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.GameSystems;

public class ExploringSystem
{
    private PlayerAbstract mPlayer;
    private StageAbstract mStage;
    private MoveStandard mMovement;
    private string mInput;

    public ExploringSystem(PlayerAbstract player, StageAbstract stage)
    {
        mPlayer = player;
        mStage = stage;
        mMovement = new MoveStandard();
    }

    public void GetInput(string input)
    {
        mInput = input;
    }

    public void MovePlayer()
    {
        var currentLocation = mPlayer.PlayerCurrentLocation;
        var newSpaceLocation = mMovement.PerformMove(TranslateInputToMovementDirection(mInput), currentLocation);
        
        if (ValidateIfPlayerMovementIsAllowed(newSpaceLocation))
        {
            mMovement.PerformMove(TranslateInputToMovementDirection(mInput), mPlayer.PlayerCurrentLocation);
        }
    }

    private bool ValidateIfPlayerMovementIsAllowed((int, int) desiredNewLocation)
    {
        return mStage.CoordinateSpace.Contains(desiredNewLocation);
    }

    private MovementDirection TranslateInputToMovementDirection(string input)
    {
        switch (input)
        {
            case "1":
                return MovementDirection.North;
            case "2":
                return MovementDirection.South;
            case "3":
                return MovementDirection.East;
            case "4":
                return MovementDirection.South;
        }

        return MovementDirection.None;
    }
}