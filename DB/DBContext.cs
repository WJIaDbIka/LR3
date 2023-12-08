using DB.Entity.Accounts;
using DB.Entity.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
	public class DBContext
	{
		public List<GameAccountEntity> accounts;
		public List<GameEntity> games;

		public DBContext() 
		{ 
			accounts = new List<GameAccountEntity>();
			games = new List<GameEntity>();
		}
	}
}
