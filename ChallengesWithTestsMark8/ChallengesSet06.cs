using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();
            if (words == null) return false;

            foreach (var something in words)
            {
                if (string.Equals(something, word, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            //throw new NotImplementedException();
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0 && i != num)
                {
                    isPrime = false;
                }

            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //throw new NotImplementedException();
            
            if (str == "" || str == null)
            {
                return -1;
            }

            int invid = -1; 
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int index = 0; index < str.Length; index++)
            {
                char currentChar = str[index];

                if (charCount.ContainsKey(currentChar))
                {
                    charCount[currentChar]++;
                }
                else
                {
                    charCount[currentChar] = 1;
                }
            }

            for (int index = 0; index < str.Length; index++)
            {
                char currentChar = str[index];

                if (charCount[currentChar] == 1)
                {
                    invid = index;
                }
            }

            return invid;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0) { return 0; }
            int initCount = 1;
            int FinalCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    initCount++;
                }
                else { initCount = 1; }

                if (initCount > FinalCount) { FinalCount = initCount; }
            }
            return FinalCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //throw new NotImplementedException();

            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0] { };
            }
            List<double> result = new List<double>();

            for (int i = n-1; i < elements.Count; i+=n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
