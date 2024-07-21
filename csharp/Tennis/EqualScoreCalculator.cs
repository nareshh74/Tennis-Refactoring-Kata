namespace Tennis;

public abstract class EqualScoreCalculator : IScoreCalculator
{
    protected Point Point;

    public static EqualScoreCalculator Create(Point point)
    {
        if (point == Point.ZeroPoint)
        {
            return new ZeroEqualPointScoreCalculator(point);
        }

        if (point == Point.FifteenPoint)
        {
            return new FifteenEqualPointScoreCalculator(point);
        }

        if (point == Point.ThirtyPoint)
        {
            return new ThirtyEqualPointScoreCalculator(point);
        }
            
        return new DeuceScoreCalculator(point);
    }

    public abstract string GetScore();
}

public class ZeroEqualPointScoreCalculator : EqualScoreCalculator
{
    public ZeroEqualPointScoreCalculator(Point point)
    {
        this.Point = point;
    }

    public override string GetScore()
    {
        return "Love-All";
    }
}

public class FifteenEqualPointScoreCalculator : EqualScoreCalculator
{
    public FifteenEqualPointScoreCalculator(Point point)
    {
        this.Point = point;
    }

    public override string GetScore()
    {
        return "Fifteen-All";
    }
}

public class ThirtyEqualPointScoreCalculator : EqualScoreCalculator
{
    public ThirtyEqualPointScoreCalculator(Point point)
    {
        this.Point = point;
    }

    public override string GetScore()
    {
        return "Thirty-All";
    }
}

public class DeuceScoreCalculator : EqualScoreCalculator
{
    public DeuceScoreCalculator(Point point)
    {
        this.Point = point;
    }

    public override string GetScore()
    {
        return "Deuce";
    }
}