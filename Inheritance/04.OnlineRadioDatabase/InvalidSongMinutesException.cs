namespace _04.OnlineRadioDatabase
{
	internal class InvalidSongMinutesException : InvalidSongLengthException
	{
		private int _minutesMin;
		private int _minutesMax;

		public InvalidSongMinutesException() : base()
		{
		}

		public InvalidSongMinutesException(string message) : base(message)
		{
		}

		public InvalidSongMinutesException(int minSongMinutes, int msxSongMinutes)
			: base($"Song minutes should be between {minSongMinutes} and {msxSongMinutes}.")
		{
		}
	}
}
