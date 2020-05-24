////////////////////////////////////////
/// Panos Triantafyllou - 22/04/2020 ///
////////////////////////////////////////
using System;

namespace ProgrammerPlusContest
{
    public class Program
    {
        public static void Main()
        {
            while (true)
                Console.WriteLine(MyMagicFunction(Console.ReadLine()));
        }

        static string MyMagicFunction(string s)
        {
            string res = null;
            for (int i = s.Length-1; i >= 0; i--)
                res += ((s[i] % 32) + s.Length-i-1).ToString();
            return res;
        }
    }
}