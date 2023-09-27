using System;

namespace MaxNumbers
{
    public class MaxNumbersOf
    {
        public int MaxNumberOfUnEquals(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Maximum number of unequal consecutive characters: 0");
                return 0;
            }

            int maxCount = 0;
            int currentCount = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            if (maxCount == 0)
            {
                return currentCount;
            }
            else
            {
                return maxCount;
            }
        }

        public int MaxNumberOfEqualsLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Maximum number of equal consecutive letters: 0");
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && Char.IsLetter(input[i - 1]))
                {
                    if (input[i] == input[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                        }
                        currentCount = 1;
                    }
                }
            }

            if (maxCount == 1 && currentCount == 1)
            {
                return 0;
            }
            else if (maxCount == 1)
            {
                return currentCount;
            }
            else
            {
                return maxCount;
            }
        }

        public int MaxNumberOfEqualsDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Maximum number of equal consecutive letters: 0");
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) && Char.IsDigit(input[i - 1]))
                {
                    if (input[i] == input[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                        }
                        currentCount = 1;
                    }
                }
            }

            if (maxCount == 1 && currentCount == 1)
            {
                return 0;
            }
            else if (maxCount == 1)
            {
                return currentCount;
            }
            else
            {
                return maxCount;
            }
        }
    }
}

