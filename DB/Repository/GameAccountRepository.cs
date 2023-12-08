using DB.Entity;
using DB.Entity.Accounts;
using DB.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repository
{
	public class GameAccountRepository : IGameAccountRepository
	{
		DBContext Context;
		public GameAccountRepository(DBContext context)
		{
			Context = context;
		}

		public void Create(GameAccountEntity account)
		{
			Context.accounts.Add(account);
		}
		public List<GameAccountEntity> GetAll()
		{
			return Context.accounts;
		}
		public GameAccountEntity Get(int id)
		{
			return Context.accounts[id];
		}
		public void Update(GameAccountEntity account)
		{
			Context.accounts.RemoveAt(account.Id);
			Context.accounts.Insert(account.Id, account);
		}
		public void Delete(GameAccountEntity account) 
		{
			Context.accounts.RemoveAt(account.Id);
			int ID = 0;
            foreach (var acc in Context.accounts)
            {
				acc.Id = ID;
				ID++;
            }
        }
		public List<GameHistoryEntity> GetHistory(GameAccountEntity account)
		{
			return account.GameHistory;
		}
	}
}
