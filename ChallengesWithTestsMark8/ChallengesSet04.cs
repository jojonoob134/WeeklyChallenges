using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0) sum += number;
                else sum -= number;
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int string1 = 0;
            int string2 = 0;

            if (str1.Length > str2.Length) string1 = str2.Length;
            else string1 = str1.Length;

            if (str3.Length > str4.Length) string2 = str4.Length;
            else string2 = str3.Length;

            if (string1 > string2) return string2;
            else return string1;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int num1 = 0;
            int num2 = 0;

            if (number1 > number2) num1 = number2;
            else num1 = number1;

            if (number3 > number4) num2 = number4;
            else num2 = number3;

            if (num1 > num2) return num2;
            else return num1;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength3 + sideLength2 > sideLength1) return true;
            return false;
        }

        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();
            double IDK = 0;
            bool isNum = double.TryParse(input, out IDK);
            if (isNum) return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            double nulls = 0;
            double total = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nulls++;
                total++;
            }
            if (total / 2 < nulls) return true;
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }
            if (count == 0) return 0;
            return sum/count;
        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();
            if (number == 0) return 1;
            if (number < 0) throw new ArgumentOutOfRangeException();
            int answer = 1;
            while (number > 0)
            {
                answer *= number;
                number--;
            }
            return answer;
        }
    }
}
