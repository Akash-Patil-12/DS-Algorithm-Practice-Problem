﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm_Programs
{
    class UnOrderedList
    {
        //variables
        string fileData, searchWord,addFileData;
        //constants
        const string FILEPATH = @"H:\dot net\DS-Algorithm-Programs\Algorithm Programs\WorldList.txt";
        LinkedList<string> linkedList = new LinkedList<string>();
        /// <summary>
        /// Perform search operation on file using linkedlist
        /// </summary>
        public void Operation()
        {
            Console.WriteLine("****************************************");
            fileData = File.ReadAllText(FILEPATH);
            Console.WriteLine("File data is :" + fileData);
            string[] splitWordList = fileData.Split(",");
            foreach(string word in splitWordList)
            {
                 linkedList.Add(word);
            }
            Console.WriteLine("Enter a word which you want to search ?");
            searchWord = Console.ReadLine();
            if (linkedList.search(searchWord) == 1)
            {
                if (linkedList.SearchAndDelete(searchWord))
                    Console.WriteLine(searchWord + " : deleted successfully");
                else
                    Console.WriteLine(searchWord + " : not deleted successfully");
            }
            else
            {
                linkedList.Add(searchWord);
            }
            Console.WriteLine("After Search list is :");
            linkedList.Display();
            addFileData = linkedList.ReturnString();
            Console.WriteLine("Wfrite :" + addFileData);
            File.WriteAllText(FILEPATH,addFileData);
        }
    }
}
