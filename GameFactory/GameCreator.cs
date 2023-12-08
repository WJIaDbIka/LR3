using Games;

namespace GameFactory
{
	class GameCreator
	{
		public GameCreator() { }

		public Game Create(GameType gameType, string opponentName, bool isWin, int rating, int gameCount)
		{
			if (gameType == GameType.CUMMON_GAME)
			{
				return new Game(opponentName, isWin, rating, gameCount);
			} else if (gameType == GameType.TRAIN_GAME)
			{
				return new TrainGame(opponentName, isWin, rating, gameCount);
			} else
			{
				return new DoubleRateGame(opponentName, isWin, rating, gameCount);
			}
		}
	}
}
