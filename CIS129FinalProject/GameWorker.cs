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
        
        // Set the PlayerStartingLocation on the stage
        
        
        //Create the batteinterface from checking the stage lcation player is in
        
        // Create Beginning Game Script 
        
        // Create
        
        
        while (isGameRunning)
        {
            // Run the Game!!!!
            
        }
    }
}