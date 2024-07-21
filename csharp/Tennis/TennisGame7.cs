using System;

namespace Tennis
{
    public class TennisGame7 : ITennisGame
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly ScoreCalculatorFactory _scoreCalculatorFactory;

        public TennisGame7(Player player1, Player player2, ScoreCalculatorFactory scoreCalculatorFactory)
        {
            this._player1 = player1;
            this._player2 = player2;
            this._scoreCalculatorFactory = scoreCalculatorFactory;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this._player1.Name)
            {
                this._player1.HasWon();
            }
            else if (playerName == this._player2.Name)
            {
                this._player2.HasWon();
            }
            else
            {
                throw new ArgumentException("Invalid player name.");
            }
        }

        public string GetScore()
        {
            var scoreCalculator = this._scoreCalculatorFactory.Create(this._player1.Point, this._player2.Point);
            return scoreCalculator.GetScore();
        }
    }
}
