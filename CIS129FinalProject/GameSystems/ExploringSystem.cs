using CIS129FinalProject.Models;
using CIS129FinalProject.Models.Actions.Movement;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.GameSystems;

public class ExploringSystem
{
    private PlayerAbstract mPlayer;
    private readonly StageAbstract mStage;
    private readonly MoveStandard mMovement;
    private BattleSystem mBattleSystem;
    private PowerUpSystem mPowerUpSystem;
    private MovementDirection mMovementDirection;

    public ExploringSystem(PlayerAbstract player, StageAbstract stage)
    {
        mPlayer = player;
        mStage = stage;
        mMovement = new MoveStandard();
        mBattleSystem = new BattleSystem(player, stage);
        mPowerUpSystem = new PowerUpSystem(player, stage);
    }

    public bool Explore()
    {
        bool isGameActive = true;
        
        while (isGameActive)
        {
            Console.WriteLine(mStage.EventDictionary[mPlayer.PlayerCurrentLocation].SpaceDescription);

            if (mBattleSystem.GetSpaceEventEnemy() is not null)
            {
                mBattleSystem.Battle();
            }
            
            // PowerUpSystem Work
            if (mPowerUpSystem.GetSpaceEventPowerUp(mPlayer.PlayerCurrentLocation) is not null)
            {
                mPowerUpSystem.ConsumePowerUp();
            }

            Console.WriteLine("Press...");
            Console.WriteLine($"1. To go North");
            Console.WriteLine($"2. To go South");
            Console.WriteLine($"3. To go East");
            Console.WriteLine($"4. To go West");
            var exploreInput = InputTranslator.GetInput();
            mMovementDirection = TranslateInputToMovementDirection(exploreInput);
            MovePlayer();


            if (mPlayer.PlayerCurrentLocation == mStage.StageExit)
            {
                Console.WriteLine($"You won the game and successfully navigated out of the {mStage.Name}!!!");
                isGameActive = false;
            }
            
            
            if (exploreInput is GameInput.TheExitOption)
            {
                isGameActive = false;
            }
        }

        return isGameActive;
    }

        public void MovePlayer()
    {
        var currentLocation = mPlayer.PlayerCurrentLocation;
        var newSpaceLocation = mMovement.PerformMove(mMovementDirection, currentLocation);
        
        if (ValidateIfPlayerMovementIsAllowed(newSpaceLocation))
        {
            mPlayer.PlayerCurrentLocation = mMovement.PerformMove(mMovementDirection, mPlayer.PlayerCurrentLocation);
        }
    }

    private bool ValidateIfPlayerMovementIsAllowed((int, int) desiredNewLocation)
    {
        return mStage.CoordinateSpace.Contains(desiredNewLocation);
    }
    
    private MovementDirection TranslateInputToMovementDirection(GameInput input)
    {
        switch (input)
        {
            case GameInput.TheFirstOption: 
                return MovementDirection.North;
            case GameInput.TheSecondOption:
                return MovementDirection.South;
            case GameInput.TheThirdOption:
                return MovementDirection.East;
            case GameInput.TheFourthOption:
                return MovementDirection.West;
            case GameInput.TheExitOption:
                break;
        }

        return MovementDirection.None;
    }
}