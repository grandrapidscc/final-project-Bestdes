using CIS129FinalProject.GameSystems;
using CIS129FinalProject.Models;
using CIS129FinalProject.Models.Stages;
using CIS129FinalProject.Processing;

namespace CIS129FinalProject;

public class GameWorker
{
    public void RunGame()
    {
        var isGameRunning = true;
        
        // Generate Type of Stage
        StageAbstract dungeonStage = new Dungeon();
        
        // Generate the Stage
        var stageGenerator = new StageGenerator(dungeonStage);
        dungeonStage = stageGenerator.GenerateStage();
        
        // Generate the Enemies on the stage
        var enemyGenerator = new EnemyGenerator(dungeonStage);
        dungeonStage = enemyGenerator.GenerateEnemiesInStage();
        
        // Generate the PowerUps on the stage
        var powerUpGenerator = new PowerUpGenerator(dungeonStage);
        dungeonStage = powerUpGenerator.GeneratePowerUpsInStage();
        
        // Generate the SpaceEvent Descriptions
        var descriptionGenerator = new SpaceEventDescriptionGenerator(dungeonStage);
        dungeonStage = descriptionGenerator.GenerateSpaceEventDescriptions();
        
        // Set the PlayerStartingLocation on the stage
        PlayerAbstract wizert = new Wizert();
        wizert.PlayerCurrentLocation = dungeonStage.PlayerStartingPosition;
        
        // Create the ExploringSystem, BattleSystem, PowerUpSystem
        ExploringSystem exploringSystem = new ExploringSystem(wizert, dungeonStage);
        
        // Create the Game Scripts

        while (isGameRunning)
        {
            // Run the Game!!!!
            isGameRunning = exploringSystem.Explore();

        }
    }
}