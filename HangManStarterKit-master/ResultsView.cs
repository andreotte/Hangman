using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class ResultsView
    {
        public List<int> guesses { get; set; }
        public Player player;
        public BatchGames batchGame;

        public ResultsView(Player player, BatchGames batchGame)
        {
            this.player = player;
            this.batchGame = batchGame;
            this.guesses = batchGame.SetGameSpeed();

        }
        public void PrintResult()
        {
            int total = 0;
            Console.Write($"{player}'s guess numbers: ");
            foreach (int result in guesses)
            {
                total += result;
                Console.Write($"{result}, ");
            }

            double average = total / guesses.Count;
            Console.WriteLine();
            Console.WriteLine($"{player} played {guesses.Count} games and had an average guess number of {average}.");
        }
    }
}
