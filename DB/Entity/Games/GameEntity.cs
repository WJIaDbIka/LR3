using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entity.Games
{
	public class GameEntity
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public bool IsWin { get; set; }
		public int Rating { get; set; }
		public int CurrentRaiting { get; set; }
		public int GameCount { get; set; }
		public int GameId { get; set; }
		public string gameType { get; set; }
	}
}
