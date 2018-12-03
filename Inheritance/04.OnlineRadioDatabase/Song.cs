using System;
using System.Collections.Generic;
using System.Text;

namespace _04.OnlineRadioDatabase
{
	public class Song
	{
		private const int _ArtistMinLength = 3;
		private const int _ArtistMaxLength = 20;
		private const int _NameMinLength = 3;
		private const int _NameMaxLength = 30;
		private const int _MinutesMin = 0;
		private const int _MinutesMax = 14;
		private const int _SecondsMin = 0;
		private const int _SecondsMax = 59;

		private string _artistName;
		private string _songName;
		private int _minutes;
		private int _seconds;

		public Song(string artist, string name, int minutes, int seconds)
		{
			ArtistName = artist;
			SongName = name;
			Minutes = minutes;
			Seconds = seconds;
		}

		private string ArtistName
		{
			set
			{
				if (value.Length < _ArtistMinLength || value.Length > _ArtistMaxLength)
				{
					throw new InvalidArtistNameException(_ArtistMinLength, _ArtistMaxLength);
				}

				_artistName = value;
			}
		}

		private string SongName
		{
			set
			{
				if (value.Length < _NameMinLength || value.Length > _NameMaxLength)
				{
					throw new InvalidSongNameException(_NameMinLength, _NameMaxLength);
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
				if (value < _MinutesMin || value > _MinutesMax)
				{
					throw new InvalidSongMinutesException(_MinutesMin, _MinutesMax);
				}

				_minutes = value;
			}
		}

		public int Seconds
		{
			get
			{
				return this._seconds;
			}

			private set
			{
				if (value < _SecondsMin || value > _SecondsMax)
				{
					throw new InvalidSongSecondsException(_SecondsMin, _SecondsMax);
				}

				this._seconds = value;
			}
		}
	}
}
