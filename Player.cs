using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    public class Player
    {
		private string name;

		public string Name
		{
			get { return this.name; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("The name of the player cannot be null or empty!");
				}
				else
				{
                    this.name = value;
                } 
			}
		}

		private string position;

		public string Position
		{
			get { return this.position; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
                    throw new ArgumentException("The position of the player cannot be null or empty!");
                }
                else
				{
                    this.position = value;
                } 
			}
		}

        public Player(string name, string position)
        {
            this.Name = name;
			this.Position = position;
        }
    }
}
