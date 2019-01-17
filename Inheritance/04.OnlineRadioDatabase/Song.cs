namespace _04.OnlineRadioDatabase
{
	public class Song
	{
		private const int ArtistMinLength = 3;
		private const int ArtistMaxLength = 20;
		private const int NameMinLength = 3;
		private const int NameMaxLength = 30;
		private const int MinutesMin = 0;
		private const int MinutesMax = 14;
		private const int SecondsMin = 0;
		private const int SecondsMax = 59;

		private string _artistName;
		private string _songName;
		private int _minutes;
		private int _seconds;

		public Song(string artist, string name, int minutes, int seconds)
		{
			_artistName = artist;
			_songName = name;
			_minutes = minutes;
			_seconds = seconds;
		}

		private string ArtistName
		{
			set
			{
				if (value.Length < ArtistMinLength || value.Length > ArtistMaxLength)
				{
					throw new InvalidArtistNameException(ArtistMinLength, ArtistMaxLength);
				}

				_artistName = value;
			}
		}

		private string SongName
		{
			set
			{
				if (value.Length < NameMinLength || value.Length > NameMaxLength)
				{
					throw new InvalidSongNameException(NameMinLength, NameMaxLength);
				}

				_songName = value;
			}
		}

		public int Minutes
		{
			get
			{
				return _minutes;
			}
			private set
			{
				if (value < MinutesMin || value > MinutesMax)
				{
					throw new InvalidSongMinutesException(MinutesMin, MinutesMax);
				}

				_minutes = value;
			}
		}

		public int Seconds
		{
			get
			{
				return _seconds;
			}

			private set
			{
				if (value < SecondsMin || value > SecondsMax)
				{
					throw new InvalidSongSecondsException(SecondsMin, SecondsMax);
				}

				_seconds = value;
			}
		}
	}
}
