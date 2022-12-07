using CIS129FinalProject.Models;
using CIS129FinalProject.Models.EnemyModels;
using CIS129FinalProject.Models.Powerups;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.GameSystems;

public class PowerUpSystem
{
    private SpaceEvent mSpaceEvent;
    private PlayerAbstract mPlayer;
    private PowerupAbstract? mPowerup;
    private StageAbstract mStage;
    private string mInput;

    public PowerUpSystem(PlayerAbstract player, StageAbstract stage)
    {
        mPlayer = player;
        mStage = stage;
        mSpaceEvent = mStage.EventDictionary[player.PlayerCurrentLocation];
        mPowerup = GetSpaceEventPowerUp(player.PlayerCurrentLocation);
    }
    
    public PowerupAbstract? GetSpaceEventPowerUp((int, int) currentSpace)
    {
        var spaceEventType = mSpaceEvent.SpaceEventType;
        bool isActivePowerUpSpaceEventEntity = spaceEventType is SpaceEventType.PowerUpEvent && mSpaceEvent.IsEventSet;

        if (isActivePowerUpSpaceEventEntity)
        {
            return (PowerupAbstract)mSpaceEvent.GetSpaceEventEntity(spaceEventType);
        }
        return null;
    }

    public void ConsumePowerUp()
    {
        Console.WriteLine($"{mPlayer.Name} found a {mPowerup?.Name}");
        mPowerup.PerformActionAgainstPlayer(mPlayer);
        mStage.EventDictionary[mPlayer.PlayerCurrentLocation].IsEventSet = false;
    }
}