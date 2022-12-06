using CIS129FinalProject.Models.EnemyModels;
using CIS129FinalProject.Models.Powerups;

namespace CIS129FinalProject.Models.Stages;

public class SpaceEvent
{
    private EnemyAbstract? mEnemy;
    private PowerupAbstract? mPowerup;
    public bool isEventSet { get; set; }
    public string SpaceDescription { get; set; }
    
    public SpaceEvent()
    {
    }

    public SpaceEvent(EnemyAbstract? enemy)
    {
        mEnemy = enemy;
        isEventSet = true;
    }

    public SpaceEvent(PowerupAbstract? powerup)
    {
        mPowerup = powerup;
        isEventSet = true;
    }
}