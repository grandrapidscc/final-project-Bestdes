using CIS129FinalProject.Models;
using CIS129FinalProject.Models.Actions;
using CIS129FinalProject.Models.EnemyModels;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.GameSystems;

public class BattleSystem
{
    private PlayerAbstract mPlayer;
    private EnemyAbstract? mEnemy;
    private StageAbstract mStage;
    private string mInput;

    public BattleSystem(PlayerAbstract player, StageAbstract stage)
    {
        mPlayer = player;
        mStage = stage;
        mEnemy = GetSpaceEventEnemy();
    }

    public EnemyAbstract? GetSpaceEventEnemy()
    {
        var spaceEvent = mStage.EventDictionary[mPlayer.PlayerCurrentLocation];
        var spaceEventType = spaceEvent.SpaceEventType;
        bool isActiveEnemySpaceEventEntity = spaceEventType is SpaceEventType.EnemyEvent && spaceEvent.IsEventSet;

        if (isActiveEnemySpaceEventEntity)
        {
            return (EnemyAbstract)spaceEvent.GetSpaceEventEntity(spaceEventType);
        }
        return null;
    }

    public bool Battle()
    {
        var isGameActive = true;
        var isActiveBattle = true;
        
        mEnemy = GetSpaceEventEnemy();
        Console.WriteLine($"{mPlayer.Name} encountered a {mEnemy?.Name}");

        while (isActiveBattle)
        {
            Console.WriteLine($"The{mEnemy?.Name}'s HP is {mEnemy?.HealthPoints}");
            Console.WriteLine($"Press...");
            
            Console.WriteLine($"1. To use {mPlayer.ActionCollection[1].Name} ");
            Console.WriteLine($"2. To use {mPlayer.ActionCollection[2].Name}");
            Console.WriteLine($"3. To use {mPlayer.ActionCollection[3].Name}");

            var battleInput = InputTranslator.GetInput();
            var action = TranslateGameInputToBattleAction(battleInput);
            isActiveBattle = PerformBattleAction(action, isActiveBattle);

            if (mEnemy.HealthPoints <= 0)
            {
                Console.WriteLine($"The {mEnemy.Name} has been defeated");
                isActiveBattle = false;
                mStage.EventDictionary[mPlayer.PlayerCurrentLocation].IsEventSet = false;
            }

            if (mEnemy.HealthPoints > 0)
            {
                mEnemy.PerformActionAgainstPlayer(mPlayer);
            }

            if (mPlayer.Hp <=0 )
            {
                Console.WriteLine($"The {mPlayer.Name} has been defeated");
                isActiveBattle = false;
            }

            if (battleInput is GameInput.TheExitOption)
            {
                isGameActive = false;
                isActiveBattle = false;
            }
        }

        return isGameActive;
    }

    private ActionAbstract TranslateGameInputToBattleAction(GameInput input)
    {
        switch (input)
        {
            case GameInput.TheFirstOption: 
                return mPlayer.ActionCollection[(int)GameInput.TheFirstOption];
            case GameInput.TheSecondOption:
                return mPlayer.ActionCollection[(int)GameInput.TheSecondOption];
            case GameInput.TheThirdOption:
                return mPlayer.ActionCollection[(int)GameInput.TheThirdOption];
            case GameInput.TheExitOption:
                break;
        }

        return new EmptyAction();
    }

    private bool PerformBattleAction(ActionAbstract action, bool isBattleActive)
    {
        switch (action.Name)
        {
            case "Flee":
                action.PerformActionAgainstEnemy(mEnemy, mPlayer);
                return !(action as Flee).WasFleeSuccessful;
            case "Heal":
                action.PerformActionAgainstPlayer(mPlayer);
                return true;
            case "Fireball":
                action.PerformActionAgainstEnemy(mEnemy, mPlayer);
                return true;
        }

        return isBattleActive;
    }
}