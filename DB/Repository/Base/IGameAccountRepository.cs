using DB.Entity;
using DB.Entity.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repository.Base
{
	public interface IGameAccountRepository
	{
		public void Create(GameAccountEntity account);
		public List<GameAccountEntity> GetAll();
		public GameAccountEntity Get(int id);
		public void Update(GameAccountEntity account);
		public void Delete(GameAccountEntity account);
		public List<GameHistoryEntity> GetHistory(GameAccountEntity account);
	}
}
