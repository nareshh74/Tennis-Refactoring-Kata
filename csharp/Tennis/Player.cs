namespace Tennis;

public class Player
{
    public Player(string name)
    {
        this.Name = name;
        this.Point = Point.ZeroPoint;
    }

    public string Name { get; }

    public Point Point { get; private set; }

    public void HasWon()
    {
        this.Point++;
    }
}