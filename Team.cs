using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    public class Team
    {
		private string name;

		public string Name
		{
			get { return this.name; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("The name of the team cannot be null or empty!");
				}
				else
				{
                    this.name = value;
                } 
			}
		}

		private List<Player> players;

		public List<Player> Players
		{
			get { return this.players; }
			set { this.players = value; }
		}

		public void AddPlayer(Player player)
		{
			if (player != null && !this.Players.Contains(player))
			{
				this.Players.Add(player);
			}
			else
			{
				throw new ArgumentException("A player like that one is already added to the team or null!");
			}
		}

		public void RemovePlayer(Player player)
		{
            if (player != null && this.Players.Contains(player))
            {
                this.Players.Remove(player);
            }
            else
            {
                throw new ArgumentException("A player like that one is already removed of the team or null!");
            }
        }

		public Team(string name)
        {
			this.Name = name;
			this.players = new List<Player>();
        }
    }
}