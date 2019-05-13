using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class BatchGames
    {
        public Player guesser;
        public bool quick;

        public BatchGames(Player guesser)
        {
            this.guesser = guesser;
        }

        // For RandomPlayer and ABCplayer allow the user to skip hitting enter after each guess
        public List<int> SetGameSpeed()
        {
            if (guesser is RandomPlayer || guesser is ABCplayer || guesser is SmartyPlayer)
            {
                Console.WriteLine();
                Console.Write("Want to play the quick version?(Y/N): ");
                string quickPlay = Console.ReadLine().Trim().ToLower();

                if (quickPlay == "y" || quickPlay == "yes")
                {
                    quick = true;
                }
            }
            return GameIterations();
        }
        public List<int> GameIterations()
        {
            Console.Write("Enter the number of games you would like to play: ");
            string games = Console.ReadLine();
            int.TryParse(games, out int gameNumber);
            List<int> tries = new List<int>();

            for (int i = 0; i < gameNumber; i++)
            {
                if (quick)
                { 
                    HangmanGame game = new HangmanGame(guesser, quick);
                    tries.Add(HangmanGame.Tries);
                }
                else
                {
                    HangmanGame game = new HangmanGame(guesser, !quick);
                    tries.Add(HangmanGame.Tries);
                }
            }

            return tries;
        }

        public double AverageTries(List<int> tries)
        {
            double total = 0;
            foreach(int attempt in tries)
            {
                total += attempt;
            }
            return total / tries.Count;
        }
    }
}
