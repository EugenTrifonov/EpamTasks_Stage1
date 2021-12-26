using System;
using System.Collections.Generic;

namespace Unequalcharacters
{
    public class UnequalCharactersSequence
    {
        private static string CharacterSequence;

        /// <summary>
        /// Get max length of unequal character sequence
        /// </summary>
        /// <param Input arguments="args"></param>
        /// <returns></returns>
        public static int GetMaxNumberofUnequalCharacters(string[] args)
        {
            int NumberofUnequalCharacters = 0;

            if (CheckInput(args))
            {
                int CurrentIndex = 0;
                string CheckedCharacters = String.Empty;
                List<int> Lengths = new List<int>();

                foreach (char character in CharacterSequence)
                {
                    if (CheckedCharacters.Contains(character.ToString()))
                    {
                        Lengths.Add(NumberofUnequalCharacters);
                        NumberofUnequalCharacters -= IndexOfSameLeftNearestCharacter(character, CharacterSequence, CurrentIndex);
                    }
                    else
                    {
                        NumberofUnequalCharacters++;
                        CheckedCharacters += character;
                    }
                    CurrentIndex++;
                }

                Lengths.Add(NumberofUnequalCharacters);
                NumberofUnequalCharacters = GetMaxIntInList(Lengths);

            }
            return NumberofUnequalCharacters;
        }

        /// <summary>
        /// Get max integer in List
        /// </summary>
        /// <param Input list="list"></param>
        /// <returns></returns>
        private static int GetMaxIntInList(List<int> list)
        {
            int max = list[0];
            foreach (int number in list)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        /// <summary>
        /// Get index of left nearest same character 
        /// </summary>
        /// <param Character thats needs to find="character"></param>
        /// <param Character sequence="sequence"></param>
        /// <param Current index of character="CurrentIndex"></param>
        /// <returns></returns>
        private static int IndexOfSameLeftNearestCharacter(char character, string sequence, int CurrentIndex)
        {
            while (sequence[CurrentIndex - 1] != character)
            {
                CurrentIndex--;
            }

            return CurrentIndex - 1;
        }

        /// <summary>
        /// Check input arguments
        /// </summary>
        /// <param Input arguments="args"></param>
        /// <returns></returns>
        private static bool CheckInput(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Empty input");
            }
            CharacterSequence = args[0];
            if (args.Length > 1)
            {
                throw new Exception("Incorrect input");
            }
            return true;
        }
    }
}