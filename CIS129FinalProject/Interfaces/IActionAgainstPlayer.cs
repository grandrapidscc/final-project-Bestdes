using CIS129FinalProject.Models;

namespace CIS129FinalProject.Interfaces;

public interface IActionAgainstPlayer
{
    void PerformActionAgainstPlayer(PlayerAbstract playerTargeted);
}