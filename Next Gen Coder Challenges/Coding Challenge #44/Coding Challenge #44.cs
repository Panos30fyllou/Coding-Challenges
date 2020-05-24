using System;
//@panos30fyllou
namespace CC44
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type every number of the list seperated by ' ' and press Enter. Then, type one of them and press Enter.");
                string[] input = Console.ReadLine().Split(" "); int x = int.Parse(Console.ReadLine());
                int[] numList = new int[input.Length];
                int index = -1; bool swaped = false;
                for (int i = 0; i < numList.Length; i++)
                {
                    numList[i] = int.Parse(input[i]);
                    if (numList[i] == x) index = i;
                }
                for (int i = 0; i < numList.Length; i++)
                {
                    if ((numList[i] > x && i < index) || (numList[i] < x && i >= index && numList[i] < numList[index + 1]))
                    {
                        numList[index] = numList[i];
                        numList[i] = x;
                        swaped = true;
                    }
                }
                for (int i = 0; i < numList.Length; i++)
                    if (i > 0 && numList[i] < numList[i - 1]) swaped = false;
                Console.WriteLine(swaped ? "Swaped " + string.Join(" ", numList) : "Not Swaped");
            }
        }
    }
}
