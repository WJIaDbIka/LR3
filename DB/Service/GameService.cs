using DB.Entity.Games;
using DB.Repository;
using DB.Service.Base;
using Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Service
{
	public class GameService : IGameService
	{
		GameRepository repository;
		public GameService(DBContext context)
		{
			repository = new GameRepository(context);
		}

		public void Create(Game game)
		{
			repository.Create(Map(game));
		}
		public List<Game> GetAll()
		{
			var list = repository.GetAll()
				.Select(x => x != null ? Map(x) : null).ToList();
			return list;
		}
		public Game Get(int id)
		{
			return Map(repository.Get(id));
		}
		public void Update(Game game)
		{
			repository.Update(Map(game));
		}
		public void Delete(Game game)
		{
			repository.Delete(Map(game));
		}

		private GameEntity Map(Game game)
		{
			return new GameEntity
			{
				Id = game.ID,
				UserName = game.UserName,
				IsWin = game.IsWin,
				Rating = game.Rating,
				CurrentRaiting = game.CurrentRaiting,
				GameCount = game.GameCount,
				GameId = game.GameId,
				gameType = game._gameType
			};
		}
		private Game Map(GameEntity game)
		{
			return new Game(game.UserName, game.IsWin, game.Rating, game.GameCount)
			{
				ID = game.Id,
				UserName = game.UserName,
				IsWin = game.IsWin,
				Rating = game.Rating,
				CurrentRaiting = game.CurrentRaiting,
				GameCount = game.GameCount,
				GameId = game.GameId,
				_gameType = game.gameType
			};
		}

		private DoubleRateGameEntity Map(DoubleRateGame game)
		{
			return new DoubleRateGameEntity
			{
				Id = game.ID,
				UserName = game.UserName,
				IsWin = game.IsWin,
				Rating = game.Rating,
				CurrentRaiting = game.CurrentRaiting,
				GameCount = game.GameCount,
				GameId = game.GameId,
				gameType = game._gameType
			};
		}
		private DoubleRateGame Map(DoubleRateGameEntity game)
		{
			return new DoubleRateGame(game.UserName, game.IsWin, game.Rating, game.GameCount)
			{
				ID = game.Id,
				UserName = game.UserName,
				IsWin = game.IsWin,
				Rating = game.Rating,
				CurrentRaiting = game.CurrentRaiting,
				GameCount = game.GameCount,
				GameId = game.GameId,
				_gameType = game.gameType
			};
		}

		private TrainGameEntity Map(TrainGame game)
		{
			return new TrainGameEntity
			{
				Id = game.ID,
				UserName = game.UserName,
				IsWin = game.IsWin,
				Rating = game.Rating,
				CurrentRaiting = game.CurrentRaiting,
				GameCount = game.GameCount,
				GameId = game.GameId,
				gameType = game._gameType
			};
		}
		private TrainGame Map(TrainGameEntity game)
		{
			return new TrainGame(game.UserName, game.IsWin, game.Rating, game.GameCount)
			{
				ID = game.Id,
				UserName = game.UserName,
				IsWin = game.IsWin,
				Rating = game.Rating,
				CurrentRaiting = game.CurrentRaiting,
				GameCount = game.GameCount,
				GameId = game.GameId,
				_gameType = game.gameType
			};
		}
	}
}
