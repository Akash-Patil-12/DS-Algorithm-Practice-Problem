using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Number_Anagram_Palindrome
    {
        //variable
        bool checkPrime = true;
        public void PrimeNumberInRange()
        {
            Console.WriteLine("****************************************");
            const int LOWERLIMIT = 0, UPPERLIMIT = 1000;
            Console.WriteLine("Prime number that are palindrome and Anagram as listed below :");
            for (int i = LOWERLIMIT; i < UPPERLIMIT; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
                if (checkPrime)
                {
                    int tempNumber = i,remainder=0,reversNumber=0;
                    while (tempNumber > 0)
                    {
                        remainder = tempNumber % 10;
                        reversNumber = reversNumber * 10 + remainder;
                        tempNumber = tempNumber / 10;
                    }
                   // Console.WriteLine("reversNumber" + reversNumber);
                    if (i == reversNumber)
                        Console.WriteLine(i);
         
                }
                checkPrime = true;
            }
        }

    }
}
