using DB.Entity.Games;
using DB.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repository
{
	public class GameRepository : IGameRepository
	{
		DBContext Context;
		public GameRepository(DBContext context)
		{
			Context = context;
		}

		public void Create(GameEntity game)
		{
			Context.games.Add(game);
		}
		public List<GameEntity> GetAll()
		{
			return Context.games;
		}
		public GameEntity Get(int id) 
		{
			return Context.games[id];
		}
		public void Update(GameEntity game)
		{
			Context.games.RemoveAt(game.Id);
			Context.games.Insert(game.Id, game);
		}
		public void Delete(GameEntity game) 
		{
			Context.games.RemoveAt(game.Id);
			int ID = 0;
			foreach (var g in Context.games)
			{
				g.Id = ID;
				ID++;
			}
		}
	}
}
