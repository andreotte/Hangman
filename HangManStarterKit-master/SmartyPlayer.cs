using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class SmartyPlayer : Player
    {
        public override char Guess()
        {
            char[] alpha = "etaoinsrhldcumfpgwybvkxjqz".ToCharArray();
            return alpha[HangmanGame.Tries];
        }
    }
}
