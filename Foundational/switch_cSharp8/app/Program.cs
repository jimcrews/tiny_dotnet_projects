using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FromRainbow("Red")); // #FF0000
            Console.WriteLine(FromRainbow("zzzz")); // #FFFFF

            Console.WriteLine(RockPaperScissors("rock", "paper")); // Paper wins
            Console.WriteLine(RockPaperScissors("", "")); // Tie
        }

        static string FromRainbow(string colour)
        {
            return colour switch
            {
                "Red" => "#FF0000",
                "Green" => "#00FF00",
                "Blue" => "#0000FF",
                _ => "#FFFFF"
            };
        }

        // switch expression with tuples
        static string RockPaperScissors(string first, string second)
        {
            // convert to a tuple so the switch can evaluate the two values in a single expression
            return (first, second) switch
            {
                ("rock", "paper") => "Paper wins",
                ("rock", "scissors") => "Rock wins",
                ("paper", "rock") => "Paper wins",
                ("paper", "scissors") => "Scissors wins",
                ("scissors", "Rock") => "Rock wins",
                ("scissors", "paper") => "Scissors wins",
                (_, _) => "Tie."
            };
        }
    }
}
