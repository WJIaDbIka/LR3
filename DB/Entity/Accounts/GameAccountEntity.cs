using DB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entity.Accounts
{
	public enum AccountType
	{
		GAME_ACCOUNT = 1,
		LOW_LOOSE_RATE_ACCOUNT=2,
		WIN_STREAK_ACCOUNT=3,
	}
	public class GameAccountEntity
	{
		public GameAccountService service {  get; set; }
		public int Id { get; set; }
		public string UserName {  get; set; }
		public int CurrentRating { get; set; }
		public List<GameHistoryEntity> GameHistory {  get; set; }
	}
}
