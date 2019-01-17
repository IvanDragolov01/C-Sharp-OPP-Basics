using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FootballTeamGenerator
{
	class Team
	{
		private string _name;
		private HashSet<Player> _players;

		public Team(string name)
		{
			_name = name;
			_players = new HashSet<Player>();
		}

		public string Name
		{
			get
			{
				return _name;
			}
			private set
			{
				bool valueNull = string.IsNullOrWhiteSpace(value);
				bool valueEmpty = value == string.Empty;

				if (valueNull || valueEmpty)
				{
					throw new ArgumentException("A name should not be empty.");
				}

				_name = value;
			}
		}

		public double GetRating()
		{
			if (_players.Count > 0)
			{
				IEnumerable<double> player = _players.Select(p => p.SkillLevel);
				return player.Average();
			}
			else
			{
				return 0;
			}
		}

		internal void AddPlayer(Player player)
		{
			_players.Add(player);
		}

		internal bool IsPlayerFound(string playerName)
		{
			Player player = _players.FirstOrDefault(p => p.Name == playerName);
			return  player != null;
		}

		internal void RemovePlayer(string playerName)
		{
			if (this == null)
			{
				throw new NullReferenceException("Team does not existent");
			}

			if (_players.Any(p => p.Name == playerName))
			{
				_players.RemoveWhere(p => p.Name == playerName);
			}
			else
			{
				throw new InvalidOperationException($"Player {playerName} is not in {Name} team.");
			}
		}
	}
}
