using System;
using Unequalcharacters;

namespace Unequal_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(UnequalCharactersSequence.GetMaxNumberofUnequalCharacters(args));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}