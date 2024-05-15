using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings_And_Numbers
{
    class StringsAndNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter input ");

            string input = Console.ReadLine();

            char[] sSplit = input.ToCharArray();

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < sSplit.Length; i++)
            {
                int counter = 1;

                for (int j = i + 1; j < sSplit.Length; j++)
                {
                    if (sSplit[i] == sSplit[j])
                    {
                        counter++;
                    }
                }

                if (!map.ContainsKey(sSplit[i]))
                {
                    map.Add(sSplit[i], counter);
                }

            }
               List<int> mapValue = map.Values.ToList();
               mapValue.Sort();
               mapValue.Reverse();

            for (int i = 0; i < 10; i++)
            {
                int number = 9 - i;

                for (int j = 0; j < sSplit.Length; j++)
                {
                    if (!map.ContainsKey(sSplit[j]))
                    {
                        continue;
                    }

                    if (map[sSplit[j]] == mapValue[i])
                    {
                        sSplit[j] = (char)(number + '0');
                    }
                }

            }
            int sum = 0;

            for (int i = 0; i < sSplit.Length; i++)
            {
                if (char.IsDigit(sSplit[i]))
                {
                    string currentNum = sSplit[i].ToString();

                    sum += int.Parse(currentNum);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
