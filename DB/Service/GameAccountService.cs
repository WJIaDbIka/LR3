using Accounts;
using DB.Entity;
using DB.Entity.Accounts;
using DB.Repository;
using DB.Service.Base;
using GHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Service
{
	public class GameAccountService : IGameAccountService
	{
		GameAccountRepository repository;
		public GameAccountService(DBContext context)
		{
			repository = new GameAccountRepository(context);
		}

		public void Create(string userName, int currentRaiting, AccountType type)
		{
			switch (type) 
			{
				case AccountType.GAME_ACCOUNT:
					repository.Create(Map(new GameAccount(userName, currentRaiting, this.GetAll().Count(), this)));
					break;
				case AccountType.LOW_LOOSE_RATE_ACCOUNT:
					repository.Create(Map(new LowLooseRateAccount(userName, currentRaiting, this.GetAll().Count(), this)));
					break;
				case AccountType.WIN_STREAK_ACCOUNT:
					repository.Create(Map(new LowLooseRateAccount(userName, currentRaiting, this.GetAll().Count(), this)));
					break;
			}

			
		}
		public List<GameAccount> GetAll()
		{
			var list = repository.GetAll()
				.Select(x => x != null ? Map(x) : null).ToList();
			return list;
		}
		public GameAccount Get(int id)
		{
			return Map(repository.Get(id));
		}
		public void Update(GameAccount account)
		{
			repository.Update(Map(account));
		}
		public void Delete(GameAccount account)
		{
			repository.Delete(Map(account));
		}
		public List<GameHistory> GetHistory(GameAccount account)
		{
			return MapHistory(repository.GetHistory(Map(account)));
		}

		private List<GameHistoryEntity> MapHistory(List<GameHistory> history)
		{
			List<GameHistoryEntity> historyEntity = new List<GameHistoryEntity>();
            foreach (var game in history)
            {
				historyEntity.Add(new GameHistoryEntity
				{
					UserName = game.UserName,
					IsWin = game.IsWin,
					CurrentRating = game.CurrentRating,
					GameId = game.GameId,
					GameCount = game.GameCount,
					GameType = game.GameType,
				});
            }
			return historyEntity;
        }
		private List<GameHistory> MapHistory(List<GameHistoryEntity> historyEntity)
		{
			List<GameHistory> history = new List<GameHistory>();
			foreach (var game in historyEntity)
			{
				history.Add(new GameHistory
				{
					UserName = game.UserName,
					IsWin = game.IsWin,
					CurrentRating = game.CurrentRating,
					GameId = game.GameId,
					GameCount = game.GameCount,
					GameType = game.GameType,
				});
			}
			return history;
		}

		private GameAccountEntity Map(GameAccount account)
		{
			return new GameAccountEntity
			{
				service = this,
				Id = account.ID,
				UserName = account.UserName,
				CurrentRating = account.CurrentRating,
				GameHistory = MapHistory(account.gameHistory)
			};
		}
		private GameAccount Map(GameAccountEntity account)
		{
			return new GameAccount(account.UserName, account.CurrentRating, account.Id, this)
			{
				service = this,
				ID = account.Id,
				UserName = account.UserName,
				CurrentRating = account.CurrentRating,
				gameHistory = MapHistory(account.GameHistory)
			};
		}

		private LowLooseRateAccountEntity Map(LowLooseRateAccount account)
		{
			return new LowLooseRateAccountEntity
			{
				service = this,
				Id = account.ID,
				UserName = account.UserName,
				CurrentRating = account.CurrentRating,
				GameHistory = MapHistory(account.gameHistory)
			};
		}
		private LowLooseRateAccount Map(LowLooseRateAccountEntity account)
		{
			return new LowLooseRateAccount(account.UserName, account.CurrentRating, account.Id, this)
			{
				service = this,
				ID = account.Id,
				UserName = account.UserName,
				CurrentRating = account.CurrentRating,
				gameHistory = MapHistory(account.GameHistory)
			};
		}

		private WinStreakAccountEntity Map(WinStreakAccount account)
		{
			return new WinStreakAccountEntity
			{
				service = this,
				Id = account.ID,
				UserName = account.UserName,
				CurrentRating = account.CurrentRating,
				GameHistory = MapHistory(account.gameHistory)
			};
		}
		private WinStreakAccount Map(WinStreakAccountEntity account)
		{
			return new WinStreakAccount(account.UserName, account.CurrentRating, account.Id, this)
			{
				service = this,
				ID = account.Id,
				UserName = account.UserName,
				CurrentRating = account.CurrentRating,
				gameHistory = MapHistory(account.GameHistory)
			};
		}
	}
}
