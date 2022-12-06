﻿using CIS129FinalProject.Models.EnemyModels;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Processing;

public class EnemyGenerator
{
    private StageAbstract mStage;
    private Random mRandomGenerator;

    public EnemyGenerator(StageAbstract stageAbstract)
    {
        mStage = stageAbstract;
        mRandomGenerator = new Random();
    }

    public StageAbstract GenerateEnemiesInStage()
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
        return DetermineIfEnemyShouldBeAdded() 
            ? new SpaceEvent(DetermineEnemyToAddToSpace()) 
            : new SpaceEvent();
    }

    private bool DetermineIfEnemyShouldBeAdded()
    {
        var determinant = mRandomGenerator.Next(100);
        if (determinant < 60)
        {
            return true;
        }

        return false;
    }

    private EnemyAbstract DetermineEnemyToAddToSpace()
    {
        var determinant = mRandomGenerator.Next(100);
        
        if (determinant < 25)
        {
            return new Banshee();
        }
        
        if (determinant < 50)
        {
            return new Orc();
        }

        return new Goblin();
    }
}