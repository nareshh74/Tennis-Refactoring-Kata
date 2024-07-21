namespace Tennis;

public class DefaultScoreCalculator : IScoreCalculator
{
    private readonly Point _point1;
    private readonly Point _point2;

    public DefaultScoreCalculator(Point point1, Point point2)
    {
        this._point1 = point1;
        this._point2 = point2;
    }
    public string GetScore()
    {
        return this._point1 + "-" + this._point2;
    }
}