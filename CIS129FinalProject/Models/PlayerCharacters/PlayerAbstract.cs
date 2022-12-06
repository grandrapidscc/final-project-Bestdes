namespace CIS129FinalProject.Models;

public class PlayerAbstract
{
    public string Name { get; set; }
    public int HP { get; set; } = 100;
    public int MP { get; set; } = 200;
    public (int, int) PlayerCurrentLocation { get; set; }
}