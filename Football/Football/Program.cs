using System.Xml.Linq;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coach coach1 = new Coach { Name = "Coach 1", Age = 53 };
            List<FootballPlayer> players1 = new List<FootballPlayer>
            {
                new Goalkeeper {Name = "Goalkeeper 1", Age = 27, Height = 1.93, Number = 1},
                new Defender { Name = "Defender 1", Number = 2, Age = 27, Height = 180 },
                new Defender { Name = "Defender 2", Number = 20, Age = 25, Height = 185 },
                new Defender { Name = "Defender 3", Number = 4, Age = 20, Height = 183 },
                new Defender { Name = "Defender 4", Number = 5, Age = 21, Height = 187 },
                new Midfielder { Name = "Midfielder 1", Number = 8, Age = 30, Height = 175 },
                new Midfielder { Name = "Midfielder 2", Number = 31, Age = 23, Height = 173 },
                new Midfielder { Name = "Midfielder 3", Number = 3, Age = 28, Height = 176 },
                new Striker {Name = "Striker 1", Number = 9, Age = 28, Height = 185},
                new Striker {Name = "Striker 2", Number = 7, Age = 35, Height = 187},
                new Striker {Name = "Striker 3", Number = 11, Age = 32, Height = 188}
            };
            Team team1 = new Team { Coach = coach1, Players = players1 };

            Coach coach2 = new Coach { Name = "Coach 2", Age = 49 };
            List<FootballPlayer> players2 = new List<FootballPlayer>
            {
                new Goalkeeper {Name = "Goalkeeper 2", Number = 99, Age = 32, Height = 1.94},
                new Defender { Name = "Defender 5", Number = 4, Age = 27, Height = 180 },
                new Defender { Name = "Defender 6", Number = 1, Age = 25, Height = 185 },
                new Defender { Name = "Defender 7", Number = 8, Age = 20, Height = 183 },
                new Defender { Name = "Defender 8", Number = 3, Age = 21, Height = 187 },
                new Midfielder { Name = "Midfielder 4", Number = 5, Age = 30, Height = 177 },
                new Midfielder { Name = "Midfielder 5", Number = 6, Age = 23, Height = 176 },
                new Midfielder { Name = "Midfielder 6", Number = 18, Age = 28, Height = 173 },
                new Striker {Name = "Striker 4", Number = 9, Age = 29, Height = 188},
                new Striker {Name = "Striker 5", Number = 7, Age = 33, Height = 187},
                new Striker {Name = "Striker 6", Number = 11, Age = 32, Height = 189}
            };
            Team team2 = new Team { Coach = coach2, Players = players2 };

            Referee referee = new Referee { Name = "Referee", Age = 40 };
            List<AssistantReferee> assistantReferees = new List<AssistantReferee>
            {
                new AssistantReferee {Name = "Assistane Referee 1", Age = 37},
                new AssistantReferee {Name = "Assistane Referee 2", Age = 38}
            };

            Game game = new Game
            {
                Team1 = team1,
                Team2 = team2,
                Referee = referee,
                AssistantReferee = assistantReferees,
                Goals = new List<Goal>(),
                Result = "",
                Winner = null
            };

            game.Goals.Add(new Goal { Minute = 32, Player = players1[10] });
            game.Goals.Add(new Goal { Minute = 50, Player = players2[3] });
            game.Goals.Add(new Goal { Minute = 89, Player = players1[9] });

            game.Result = "2-1";
            game.Winner = team1;

            Console.WriteLine("Game Result:");
            Console.WriteLine($"Team 1: {game.Team1.Coach.Name}");
            Console.WriteLine($"Team 2: {game.Team2.Coach.Name}");
            Console.WriteLine($"Referee: {game.Referee.Name}");
            Console.WriteLine($"Assistant Referees: {game.AssistantReferee[0].Name} and {game.AssistantReferee[1].Name}");
            Console.WriteLine();
            Console.WriteLine("Goals:");
            foreach (var goal in game.Goals)
            {
                Console.WriteLine($"Minute: {goal.Minute}, Player: {goal.Player.Name}");
            }
            Console.WriteLine($"Result: {game.Result}");
            Console.WriteLine($"Winner: {game.Winner.Coach.Name}");
        }
    }
}