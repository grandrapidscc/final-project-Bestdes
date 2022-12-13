using CIS129FinalProject.Models.Actions;
using CIS129FinalProject.Models.Actions.Attacks;

namespace CIS129FinalProject.Models;

public class Wizert : PlayerAbstract
{
    public override string Name { get; set; } = "Wizert";
    public override int Hp { get; set; } = 100;
    public override int Mp { get; set; } = 200;
    public override (int, int) PlayerCurrentLocation { get; set; }

    public override Dictionary<int, ActionAbstract> ActionCollection { get; set; } = new ();


    private readonly Flee mFleeAction = new Flee();
    private readonly Heal mHealAction = new Heal();
    private readonly Fireball mFireballAction = new Fireball();
    
    public Wizert()
    {
        PopulatePlayerActions();
    }

    private void PopulatePlayerActions()
    {
        /*ActionCollection.Add(mFleeAction.Name, mFleeAction);
        ActionCollection.Add(mHealAction.Name, mHealAction);
        ActionCollection.Add(mFireballAction.Name, mFireballAction);*/
        
        ActionCollection.Add(1, mFleeAction);
        ActionCollection.Add(2, mHealAction);
        ActionCollection.Add(3, mFireballAction);
    }
}