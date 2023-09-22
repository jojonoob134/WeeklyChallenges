using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            bool isFalse = false;
            foreach (bool fal in vals)
            {
                if (!fal)
                {
                    isFalse = true;
                    return isFalse;
                }
            }
            return isFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null) return false;
            int oddOdds = 0;
            foreach (var odds in numbers)
            {
                if (odds % 2 == 1 || odds % 2 == -1)
                {
                    oddOdds++;
                }
            }
            if (oddOdds % 2 == 1)
            {
                return true;
            }
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            bool upLowNum = false;
            bool up = password.Any(char.IsUpper);
            bool low = password.Any(char.IsLower);
            bool num = password.Any(char.IsNumber);
            if (up && low && num)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            char letterFirst = val[0];
            return letterFirst;
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            char letterLast = val[val.Length - 1];
            return letterLast;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            int[] nums = new int[50];
            int times = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    nums[times] = i;
                    times++;
                }
                
                
            }
            return nums;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
