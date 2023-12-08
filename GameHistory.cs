using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHistory
{
	public class GameHistory
	{
		public string UserName { get; set; }
		public bool IsWin {  get; set; }
		public int CurrentRating {  get; set; }
		public int GameId {  get; set; }
		public int GameCount { get; set; }
		public string GameType { get; set; }
	}
}
