using HangmanAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class RandomPlayer : Player
    {
        Random rand = new Random();

        public override char Guess()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int index = rand.Next(0, alpha.Length);
            return alpha[index];
        }
    }
}
