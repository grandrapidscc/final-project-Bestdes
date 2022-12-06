using CIS129FinalProject.Models.Actions;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models;

public class Wizert : PlayerAbstract
{
    public int HP { get; set; } = 100;
    public int MP { get; set; } = 200;
    public (int, int) PlayerCurrentLocation { get; set; }

    private Flee mFlee;
    private Heal mHeal;
    private Fireball mFireball;
}