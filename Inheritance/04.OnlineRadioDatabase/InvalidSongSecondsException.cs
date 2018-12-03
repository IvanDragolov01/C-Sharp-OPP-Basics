namespace _04.OnlineRadioDatabase
{
	internal class InvalidSongSecondsException : InvalidSongLengthException
	{
		private int _secondsMin;
		private int _secondsMax;

		public InvalidSongSecondsException()
		{
		}

		public InvalidSongSecondsException(string message) : base(message)
		{
		}

		public InvalidSongSecondsException(int minSongSeconds, int maxSongSeconds)
			: base($"Song seconds should be between {minSongSeconds} and {maxSongSeconds}.")
		{
		}
	}
}
