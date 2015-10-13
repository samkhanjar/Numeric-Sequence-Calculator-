using System.Collections.Generic;

namespace NumricSequenceCalculator.Classes
{
    public class GenerateSequence : Interfaces.ISequence
    {
        public List<int> AllNumbers(int number)
        {
            List<int> lstNumbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                lstNumbers.Add(i);                
            }

            return lstNumbers;
        }

        public List<string> AllNumbersMultipleOf(int number)
        {
            List<string> lstNumbers = new List<string>();

            for (int i = 1; i <= number; i++)
            {
                lstNumbers.Add(MultipleOf(i));
            }

            return lstNumbers;
        }

        public List<int> EvenSequence(int number)
        {
            List<int> lstNumbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (IsEven(i))
                {
                    lstNumbers.Add(i);
                }             
            }

            if (!lstNumbers.Contains(number))
            {
                lstNumbers.Add(number);
            }

            return lstNumbers;
        }

        public List<int> OddSequence(int number)
        {
            List<int> lstNumbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (IsOdd(i))
                {
                    lstNumbers.Add(i);
                }
            }

            if (!lstNumbers.Contains(number))
            {
                lstNumbers.Add(number);
            }

            return lstNumbers;
        }

        private static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private string MultipleOf(int number)
        {
            if (number % 3 == 0 && number % 5 != 0)
            {
                return "C";
            }
            else if(number % 3 != 0 && number % 5 == 0)
            {
                return "E";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                return "Z";
            }
            else
            {
                return number.ToString();
            }
        }

        public List<int> FabonacciSequence(int number)
        {
            List<int> lstNumbers = new List<int>();
            int x = 0;
            int y = 1;
            
            for (int i = 0; i < number; i++)
            {
                int temp = x;
                x = y;
                y = temp + y;

                if (x > number)
                {
                    if (!lstNumbers.Contains(number))
                    {
                        lstNumbers.Add(number);
                    }                      
                }

                lstNumbers.Add(x);
            }

            if (!lstNumbers.Contains(number))
            {
                lstNumbers.Add(number);
            }

            return lstNumbers;
        }
    }
}