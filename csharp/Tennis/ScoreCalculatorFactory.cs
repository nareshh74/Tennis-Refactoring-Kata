using System;

namespace Tennis
{
    public class ScoreCalculatorFactory
    {
        public IScoreCalculator Create(Point p1, Point p2)
        {
            if(p1 == p2)
            {
                return EqualScoreCalculator.Create(p1);
            }
            if((p1.Value >= 4 || p2.Value >= 4))
            {
                return Math.Abs(p1.Value - p2.Value) == 1 ?
                    new AdvantageScoreCalculator(p1, p2) :
                    new WinScoreCalculator(p1, p2);
            }
            return new DefaultScoreCalculator(p1, p2);
        }
    }
}
