using CIS129FinalProject.Models;

namespace CIS129FinalProject.Interfaces;

public interface IEnemyAction
{
    void PerformActionAgainstPlayer(PlayerAbstract playerTargeted);
}