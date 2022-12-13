using CIS129FinalProject.Interfaces;
using CIS129FinalProject.Models.EnemyModels;

namespace CIS129FinalProject.Models.Actions;

public class Flee : ActionAbstract
{
    public override string Name { get; set; } = "Flee";
    public override int MpCost { get; set; } = 0;
    public override string Description { get; set; } = "The Wizert attempts to flee from battle";
    public override string EffectDescription { get; set; } = "Has a chance of allowing the Wizert to escape.";
    public override int EffectResult { get; set; }

    public bool WasFleeSuccessful = false;

    public override void PerformActionAgainstEnemy(EnemyAbstract enemyTargeted, PlayerAbstract playerTargeted)
    {
        var fleeMessageSuccess = $"{playerTargeted.Name} has successfully fled the battle!";
        var fleeMessageFail = $"{playerTargeted.Name} has failed to flee the battle!";

        base.PerformActionAgainstPlayer(playerTargeted);

        bool wasFleeSuccessful = DetermineIfFleeWasSuccessful(enemyTargeted);
        WasFleeSuccessful = wasFleeSuccessful;
        var fleeMessage = wasFleeSuccessful ? fleeMessageSuccess : fleeMessageFail;
        Console.WriteLine(fleeMessage);
    }


    private bool DetermineIfFleeWasSuccessful(EnemyAbstract enemyAbstract)
    {
        var chanceToFlee = DetermineChanceToFlee(enemyAbstract);
        Random randomGenerator = new Random();
        var determinant = randomGenerator.Next(100);

        if (chanceToFlee >= determinant)
        {
            return true;
        }

        return false;
    }

    private static int DetermineChanceToFlee(EnemyAbstract enemyTargeted)
    {
        var chanceToFlee = 0;
        switch (enemyTargeted.Name)
        {
            case "Banshee":
                chanceToFlee = 10;
                break;
            case "Orc":
                chanceToFlee = 20;
                break;
            case "Goblin":
                chanceToFlee = 5;
                break;
        }

        return chanceToFlee;
    }
}