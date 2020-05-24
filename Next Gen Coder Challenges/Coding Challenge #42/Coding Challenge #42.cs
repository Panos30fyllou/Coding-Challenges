//@panos30fyllou
using System;

namespace CC42{
    public class Program{
        public static void Main(string[] args){            
            char[] s = Console.ReadLine().ToCharArray();
            for (int i = 0; i < s.Length; i++)
                if (s[i] != s[s.Length - i - 1])
                    s[s.Length - i - 1] = s[i];
            Console.Write(string.Join("", s));
        }
    }
}