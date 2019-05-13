using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAI
{
    class HangmanGame
    {
        //this is the word you're trying to guess
        public string word;
        public static int Tries { get; set; }
        //public int tries = 0;
        public List<char> guessedLetters = new List<char>();
        public List<char> foundLetters = new List<char>();
        List<string> wordBank = new List<string>{ "three","apple","tree", "flee", "peel", "bells" };
        Player guesser;
        bool quick;
        Random r = new Random();

        public HangmanGame(Player guesser, bool quick)
        {
            this.guesser = guesser;
            Tries = 0;
            int index = r.Next(0, wordBank.Count);
            word = wordBank[index];
            this.quick = quick;
            Setup();
        }

        public HangmanGame(Player guesser, string word)
        {
            this.guesser = guesser;
            this.word = word;
            Setup();
        }

        private void Setup()
        {
            for (int i = 0; i < word.Length; i++)
            {
                foundLetters.Add('_');
            }
            Run();
        }

        public void Run()
        {
            while (HasWon() == false)
            {
                Console.WriteLine();
                //PrintProgress();
                Console.WriteLine("Please guess a letter");
                char c = guesser.Guess();
                Console.WriteLine(c);
                PlayRound(c);
            }
            //PrintProgress();
        }

        public bool HasWon()
        {
            for(int i = 0; i < word.Length; i++)
            {
                if(foundLetters[i] != word[i])
                {
                    return false;
                }
            }
            //Console.WriteLine("You won! Good Job!");
            return true;
        }

        public void PlayRound(char guess)
        {
            Tries++;

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("hi");
                Console.WriteLine("You already guessed that!");
            }
            else if (word.Contains(guess))
            {
                Console.WriteLine("Found a letter!");    
                
                List<int> foundIndexes = new List<int>();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                        foundIndexes.Add(i);
                }

                for(int i = 0; i < foundIndexes.Count; i++)
                {
                    int indexOf = foundIndexes[i];
                    foundLetters[indexOf] = guess;
                }

                guessedLetters.Add(guess);
            }
            else
            {
                Console.WriteLine("No Letter found...");
            }

            if(quick == false)
            {
                Console.ReadLine();
            } 

            Console.Clear();
             
        }

        //public void PrintProgress()
        //{
        //    foreach(char c in foundLetters)
        //    {
        //        Console.Write(c + " ");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("You have guessed: {0} times", Tries);
        //}
    }
}
