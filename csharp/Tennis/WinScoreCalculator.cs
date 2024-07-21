namespace Tennis;

public class WinScoreCalculator : IScoreCalculator
{
    private readonly Point _point1;
    private readonly Point _point2;

    public WinScoreCalculator(Point point1, Point point2)
    {
        this._point1 = point1;
        this._point2 = point2;
    }

    public string GetScore()
    {
        return this._point1.Value - this._point2.Value >= 2 ? "Win for player1" : "Win for player2";
    }
}