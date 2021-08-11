using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm_Programs
{
    class SearchWorldFromWorldList
    {
        //variables
        string searchWord, wordList;
        bool checkWorldFound=false;
        //constants
        const string FILEPATH =@"H:\dot net\DS-Algorithm-Programs\Algorithm Programs\WorldList.txt";
       /// <summary>
       /// Search specific word found in list or not
       /// </summary>
        public void SearchWorld()
        {
            Console.WriteLine("****************************************");
            wordList = File.ReadAllText(FILEPATH);
            string[] words = wordList.Split(",");
            Console.WriteLine("Enter the word which you want to search ?");
            searchWord = Console.ReadLine();
            foreach (string word in words)
            {
                if (word.Equals(searchWord))
                {
                    Console.WriteLine(searchWord + " : found in list");
                    checkWorldFound = true;
                    break;
                }
            }
            if (checkWorldFound == false)
                Console.WriteLine(searchWord + " : not found in list");
        }
    }
}
