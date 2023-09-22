using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            bool isLetter = Char.IsLetter(c);
            return isLetter;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int isEven = vals.Length;
            
            if (isEven % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool IsNumberEven(int number)
        {
            bool isTrue = false;
            if (number % 2 == 0)
            {
                isTrue = true;
            }
            return isTrue;

        }

        public bool IsNumberOdd(int num)
        {
            
            bool isTrue = false;
            if (num < 0)
            {
                num = -num;
            }
            if (num % 2 == 1)
            {
                isTrue = true;
            }
            return isTrue;

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null) { return 0;}
            if (!numbers.Any()) { return 0; }

            

            double min = numbers.First();
            double max = numbers.Last();
            
            foreach (var item in numbers)
            {
                if (item < min)
                {
                    min = item;
                }
                else if (item > max)
                { 
                    max = item;
                }
                
            }
            double sum = max + min;
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            int truLength = 0;
            if (length1 < length2)
            {
                truLength = length1;
            }
            else
            {
                truLength = length2;
            }
            return truLength;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) 
            { 
                return 0;
            }
            foreach (int num in numbers)
            {
                
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (int num in numbers)
            {
                int even = num % 2;
                if (even == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int num in numbers)
            {

                sum += num;
            }
            if (sum % 2 == 0) { return false; }
            else { return true; }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
            int lowerOne = 0;
            while (number > 0)
            {
                number--;
                long isOdd = number % 2;
                if (isOdd == 1)
                {
                    lowerOne++;
                }

            }
            return lowerOne;
        }
    }
}
