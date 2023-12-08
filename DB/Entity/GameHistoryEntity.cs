using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entity
{
	public class GameHistoryEntity
	{
		public string UserName { get; set; }
		public bool IsWin { get; set; }
		public int CurrentRating { get; set; }
		public int GameId { get; set; }
		public int GameCount { get; set; }
		public string GameType { get; set; }
	}
}
