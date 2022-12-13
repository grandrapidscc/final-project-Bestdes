using CIS129FinalProject.Models;
using CIS129FinalProject.Models.EnemyModels;

namespace CIS129FinalProject.Interfaces;

public interface IActionAgainstEnemy
{
    void PerformActionAgainstEnemy(EnemyAbstract enemyTargeted, PlayerAbstract player);
}