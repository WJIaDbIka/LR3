using Accounts;
using DB.Service;
using GameFactory;
using Games;

namespace GameStarter
{
	class GameStarter
	{
		GameService service;
		private GameAccount Player1;
		private GameAccount Player2;
		private int GameCount;
		private GameCreator gameCreator;
		public GameStarter(GameAccount player1, GameAccount player2, GameService _service) {
			Player1 = player1;
			Player2 = player2;
			GameCount = 0;
			gameCreator = new GameCreator();
			service = _service;
		}

		public void Start(GameType gameType, int rating)
		{
			GameCount++;
			var rand = new Random();
			if (rand.Next(0, 2) == 0)
			{
				var player1Game = gameCreator.Create(gameType, Player1.UserName, true, rating, GameCount);
				var player2Game = gameCreator.Create(gameType, Player2.UserName, false, rating, GameCount);

				service.Create(player1Game);
				service.Create(player2Game);

				Player1.WinGame(player1Game);
				Player2.LoseGame(player2Game);

				player1Game.CurrentRaiting = Player1.CurrentRating;
				player2Game.CurrentRaiting = Player2.CurrentRating;

			} else
			{
				var player1Game = gameCreator.Create(gameType, Player1.UserName, false, rating, GameCount);
				var player2Game = gameCreator.Create(gameType, Player2.UserName, true, rating, GameCount);

				service.Create(player1Game);
				service.Create(player2Game);

				Player1.LoseGame(player1Game);
				Player2.WinGame(player2Game);

				player1Game.CurrentRaiting = Player1.CurrentRating;
				player2Game.CurrentRaiting = Player2.CurrentRating;
			}
			Game._gameId += 10;
		}
	}
}
