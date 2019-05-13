using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class Program
    {
        static void Main(string[] args)
        {

            Player smarty = new SmartyPlayer();
            BatchGames bgSmarty = new BatchGames(smarty);
            ResultsView resultsViewSmarty = new ResultsView(smarty, bgSmarty);
            resultsViewSmarty.PrintResult();

            Player abcPlayer = new ABCplayer();
            BatchGames bgABC = new BatchGames(abcPlayer);
            ResultsView resultsViewABC = new ResultsView(abcPlayer, bgABC);
            resultsViewABC.PrintResult();

            Player randy = new RandomPlayer();
            BatchGames bgRandy = new BatchGames(randy);
            ResultsView resultsViewRandy = new ResultsView(randy, bgRandy);
            resultsViewRandy.PrintResult();

        }
    }
}
