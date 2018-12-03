namespace _04.OnlineRadioDatabase
{
	internal class InvalidSongNameException : InvalidSongException
	{
		private int _nameMinLength;
		private int _nameMaxLength;

		public InvalidSongNameException() : base()
		{
		}

		public InvalidSongNameException(string message) : base(message)
		{
		}

		public InvalidSongNameException(int minNameLength, int maxNameLength)
			: base($"Song name should be between {minNameLength} and {maxNameLength} symbols.")
		{
		}
	}
}
