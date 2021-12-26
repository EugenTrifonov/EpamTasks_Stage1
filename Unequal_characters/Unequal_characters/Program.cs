using System;

namespace UnequalCharacters
{
     public class Program
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