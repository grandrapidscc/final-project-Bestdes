using CIS129FinalProject.Models.Powerups;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Processing;

public class PowerUpGenerator
{
    private StageAbstract mStage;
    private Random mRandomGenerator;

    public PowerUpGenerator(StageAbstract stageAbstract)
    {
        mStage = stageAbstract;
        mRandomGenerator = new Random();
    }

    public StageAbstract GeneratePowerUpsInStage()
    {
        foreach (var cSpace in mStage.CoordinateSpace)
        {
            if (mStage.EventDictionary[cSpace].isEventSet is false)
            {
                mStage.EventDictionary.Add(cSpace, DetermineSpaceEvent());
                mStage.EventDictionary[cSpace].isEventSet = true;
            }
        }

        return mStage;
    }

    private SpaceEvent DetermineSpaceEvent()
    {
        return DetermineIfPowerUpShouldBeAdded() 
            ? new SpaceEvent(DeterminePowerUpToAddToSpace()) 
            : new SpaceEvent();
    }

    private bool DetermineIfPowerUpShouldBeAdded()
    {
        var determinant = mRandomGenerator.Next(100);
        if (determinant < 40)
        {
            return true;
        }

        return false;
    }

    private PowerupAbstract DeterminePowerUpToAddToSpace()
    {
        var determinant = mRandomGenerator.Next(100);
        if (determinant < 50)
        {
            return new HealthPotion();
        }

        return new MagickaPotion();
    }
}