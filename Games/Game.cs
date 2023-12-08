namespace Games
{
	enum GameType
	{
		CUMMON_GAME = 1,
		TRAIN_GAME = 2,
		DOUBLE_RATE_GAME = 3,
	}

    public class Game
    {
        public int ID {  get; set; }
        public string UserName { get; set; }
        public bool IsWin { get; set; }
        public int Rating { get; set; }
        public int CurrentRaiting{ get; set; }
        public int GameCount { get; set; }
        public static int _gameId;
        public int GameId { get; set; }
        public string _gameType { get; set; }

	public Game(string userName, bool isWin, int rating, int gameCount)
        {
            UserName = userName;
            IsWin = isWin;
            Rating = rating;
            GameCount = gameCount;
            GameId = _gameId;
            _gameType = "Cummon Game";

		}

        virtual public int CountRaiting()
        {
			return Rating;
		}
    }
}
