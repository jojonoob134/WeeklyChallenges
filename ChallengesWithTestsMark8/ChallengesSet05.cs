using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //throw new NotImplementedException();
            do
            {
                startNumber++;
            } while (startNumber % n != 0 || startNumber == 0);
                return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();
            int count = 0;
            foreach (Business biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                {
                    businesses[count].Name = "CLOSED";
                }
                count++;
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            int[] isOrder = numbers.ToArray();

            Array.Sort(isOrder);

            bool isSame = isOrder.SequenceEqual(numbers);


            return isSame;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();
            int sum = 0;
            if (numbers == null) return 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i + 1 < numbers.Length)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //throw new NotImplementedException();
            
            if (words == null || words.Length == 0) return "";

            string sentence = "";
            string word = "";
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                word = word.Trim();
                if (word.Length != 0 && i + 1 < words.Length)
                {
                    sentence += word + " ";
                }
                if (word.Length != 0 && i + 1 == words.Length)
                {
                    sentence += word + ".";
                }
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //throw new NotImplementedException();
            List<double> result = new List<double>();
            if (elements == null) return new double[] { };
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //throw new NotImplementedException();
            int sum = 0;
            int arr1 = 0;
            int arr2 = 0;
            if (nums == null || nums.Length == 0) { return false; }
            foreach (int num1 in nums)
            {
                foreach (int num2 in nums)
                {
                    sum = num1 + num2;
                    if (sum == targetNumber && arr1 != arr2) { return true; }
                    //break;
                    arr2++;
                }
                arr1++;
                arr2 = 0;
            }
            return false;
        }
    }
}
