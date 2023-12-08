namespace Games
{
	class TrainGame : Game
	{
		public TrainGame(string opponentName, bool isWin, int rating, int gameCount) : base(opponentName, isWin, rating, gameCount) {
			_gameType = "Train Game";
		}

		public override int CountRaiting()
		{
			return 0;
		}
	}
}
