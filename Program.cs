using Accounts;
using DB;
using DB.Service;
using Games;

class Program
{
    static void Main()
    {
        Game._gameId = 1000;

        DBContext context = new DBContext();
        GameAccountService accService = new GameAccountService(context);
        GameService gameService = new GameService(context);
               
        accService.Create("Player1", 10, DB.Entity.Accounts.AccountType.WIN_STREAK_ACCOUNT);
                       
        accService.Create("Player2", 12, DB.Entity.Accounts.AccountType.LOW_LOOSE_RATE_ACCOUNT);

        var gameStarter = new GameStarter.GameStarter(accService.Get(0), accService.Get(1), gameService);
        gameStarter.Start(GameType.CUMMON_GAME, 10);
		gameStarter.Start(GameType.CUMMON_GAME, 10);

		gameStarter.Start(GameType.TRAIN_GAME, 10);
		gameStarter.Start(GameType.TRAIN_GAME, 10);

		gameStarter.Start(GameType.DOUBLE_RATE_GAME, 10);
		gameStarter.Start(GameType.DOUBLE_RATE_GAME, 10);

		var accounts = accService.GetAll();
        foreach (var acc in accounts)
        {
            if (acc != null)
            {
                acc.GetStats();
            }
        }
    }
}
