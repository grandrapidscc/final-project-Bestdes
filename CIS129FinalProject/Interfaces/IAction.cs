using CIS129FinalProject.Models;
using CIS129FinalProject.Models.EnemyModels;

namespace CIS129FinalProject.Interfaces;

public interface IAction
{
    void PerformAction();
    void PerformActionAgainstPlayer(PlayerAbstract playerTargeted);
}