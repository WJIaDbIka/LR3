using DB.Service;

namespace Accounts
{
	class LowLooseRateAccount : GameAccount
	{
		public LowLooseRateAccount(string userName, int currentRaiting, int id, GameAccountService service) : base(userName, currentRaiting, id, service) { }

		protected override int CalcRate(bool isWin, int rating)
		{
			if (isWin)
			{
				return rating;
			} else
			{
				return -rating / 2;
			}
		}
	}
}
