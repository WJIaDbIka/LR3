namespace Games
{
	class DoubleRateGame : Game
	{
		public DoubleRateGame(string opponentName, bool isWin, int rating, int gameCount) : base(opponentName, isWin, rating, gameCount) {
			_gameType = "Double Rate Game";
		}

		public override int CountRaiting()
		{
			return Rating * 2;
		}
	}
}
