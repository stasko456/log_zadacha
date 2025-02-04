using project_1;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {
        ILog logger = new LogTXT();
        List<Player> players = new List<Player>();
        List<Team> teams = new List<Team>();
        string[] input = Console.ReadLine().Split(' ').ToArray();

        while (input[0] != "exit")
        {
            switch (input[0])
            {
                case "create_team":
                    Team team = new Team(input[1]);
                    teams.Add(team);
                    logger.Log($"Team has been made: name{input[1]}.");
                    break;
                case "create_player":
                    Player player = new Player(input[1], input[2]);
                    players.Add(player);
                    logger.Log($"Player has been made: name:{input[1]}, position:{input[2]}.");
                    break;
                case "add_player":
                    Team teamSearch = teams.FirstOrDefault(x => x.Name == input[1]);
                    Player playerSearch = players.FirstOrDefault(x => x.Name == input[2] && x.Position == input[3]);
                    teamSearch.AddPlayer(playerSearch);
                    break;
                case "remove_player":
                    Team teamSearch1 = teams.FirstOrDefault(x => x.Name == input[1]);
                    Player playerSearch1 = players.FirstOrDefault(x => x.Name == input[2] && x.Position == input[3]);
                    teamSearch1.RemovePlayer(playerSearch1);
                    break;
                default:
                    break;
            }
            input = Console.ReadLine().Split(' ').ToArray();
        }
    }
}
