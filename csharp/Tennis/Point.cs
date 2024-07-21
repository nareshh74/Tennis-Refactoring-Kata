using System;

namespace Tennis;

public record Point
{
    protected int _value;

    public int Value => this._value;

    public static Point ZeroPoint => new ZeroPoint();
    public static Point FifteenPoint => new FifteenPoint();
    public static Point ThirtyPoint => new ThirtyPoint();
    public static Point FortyPoint => new FortyPoint();
    public static Point GreaterThanFortyPoint(int pointValue) => new GreaterThanFortyPoint(pointValue);

    public static Point operator ++(Point point)
    {
        if(point is ZeroPoint)
        {
            return Point.FifteenPoint;
        }
        if(point is FifteenPoint)
        {
            return Point.ThirtyPoint;
        }
        if(point is ThirtyPoint)
        {
            return Point.FortyPoint;
        }
        return new GreaterThanFortyPoint(point.Value + 1);
    }
}

internal record ZeroPoint : Point
{
    public ZeroPoint()
    {
        this._value = 0;
    }

    public override string ToString() => "Love";
}
internal record FifteenPoint : Point
{
    public FifteenPoint()
    {
        this._value = 1;
    }
    public override string ToString() => "Fifteen";
}
internal record ThirtyPoint : Point
{
    public ThirtyPoint()
    {
        this._value = 2;
    }
    public override string ToString() => "Thirty";
}
internal record FortyPoint : Point
{
    public FortyPoint()
    {
        this._value = 3;
    }
    public override string ToString() => "Forty";
}
internal record GreaterThanFortyPoint : Point
{
    public GreaterThanFortyPoint(int pointValue)
    {
        this._value = pointValue;
    }

    public override string ToString()
    {
        throw new InvalidOperationException("Invalid point value.");
    }
}