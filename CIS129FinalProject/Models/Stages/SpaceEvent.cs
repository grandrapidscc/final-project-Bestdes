using CIS129FinalProject.Models.EnemyModels;
using CIS129FinalProject.Models.Powerups;

namespace CIS129FinalProject.Models.Stages;

public class SpaceEvent
{
    public SpaceEventType SpaceEventType { get; set; } = SpaceEventType.None;
    public bool IsEventSet { get; set; } = false;
    public string SpaceDescription { get; set; } = "None";

    private EnemyAbstract? mEnemy;
    private PowerupAbstract? mPowerup;
    
    public SpaceEvent()
    {
    }

    public SpaceEvent(EnemyAbstract? enemy)
    {
        mEnemy = enemy;
        IsEventSet = true;
    }

    public SpaceEvent(PowerupAbstract? powerup)
    {
        mPowerup = powerup;
        IsEventSet = true;
    }

    public SpaceEventEntity GetSpaceEventEntity(SpaceEventType spaceEventType)
    {
        SpaceEventEntity? spaceEventEntity = null;
        switch (spaceEventType)
        {
            case SpaceEventType.EnemyEvent:
                spaceEventEntity = mEnemy;
                break;
            case SpaceEventType.PowerUpEvent:
                spaceEventEntity = mPowerup;
                break;
        }

        return spaceEventEntity;
    }
}