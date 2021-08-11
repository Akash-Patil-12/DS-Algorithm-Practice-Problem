using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Permutation
    {
        /// <summary>
        /// Return permutation of string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ans"></param>
        public void PrintPermutation(string str, string ans)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(ans + " ");
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                string ros = str.Substring(0, i) + str.Substring(i + 1);
                PrintPermutation(ros, ans + ch);
            }
        }
    }
}
