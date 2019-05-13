using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class ABCplayer : Player
    {
        public override char Guess()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            return alpha[HangmanGame.Tries];    
        }
    }
}
