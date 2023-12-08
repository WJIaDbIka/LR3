using Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Service.Base
{
	public interface IGameService
	{
		public void Create(Game game);
		public List<Game> GetAll();
		public Game Get(int id);
		public void Update(Game game);
		public void Delete(Game game);
	}
}
