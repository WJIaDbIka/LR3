using Accounts;
using DB.Entity.Accounts;
using GHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Service.Base
{
	public interface IGameAccountService
	{
		public void Create(string userName, int currentRaiting, AccountType type);
		public List<GameAccount> GetAll();
		public GameAccount Get(int id);
		public void Update(GameAccount account);
		public void Delete(GameAccount account);
		public List<GameHistory> GetHistory(GameAccount account);
	}
}
