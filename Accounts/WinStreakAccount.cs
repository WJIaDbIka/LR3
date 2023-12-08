using DB.Service;

namespace Accounts
{
	class WinStreakAccount : GameAccount
	{
		private static int streakCount = 0;
		public WinStreakAccount(string userName, int currentRaiting, int id, GameAccountService service) : base(userName, currentRaiting, id, service) { }

		protected override int CalcRate(bool isWin, int rating)
		{
			if (isWin)
			{
				streakCount++;
				return rating + streakCount - 1;
			} else
			{
				streakCount = 0;
				return -rating;
			}
		}
	}
}
