using CIS129FinalProject.Models.Actions;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models;

public abstract class PlayerAbstract
{
    public abstract string Name { get; set; }
    public abstract int Hp { get; set; }
    public abstract int Mp { get; set; }
    public abstract (int, int) PlayerCurrentLocation { get; set; }
    public abstract Dictionary<int, ActionAbstract> ActionCollection { get; set; }
    
}