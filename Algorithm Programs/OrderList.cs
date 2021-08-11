using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm_Programs
{
    class OrderList
    {
        string fileData;
        int searchNumber;
        //constants
        const string FILEPATH = @"H:\dot net\DS-Algorithm-Programs\Algorithm Programs\IntegerList.txt";
        LinkedList<int> linkedList = new LinkedList<int>();
        public void Operation()
        {
            Console.WriteLine("****************************************");
            fileData = File.ReadAllText(FILEPATH);
            Console.WriteLine("File data is :" + fileData);
            string[] splitWordList = fileData.Split(",");
            foreach (string word in splitWordList)
            {
                linkedList.Add(Convert.ToInt16(word));
            }
            Console.WriteLine("Enter a Number which you want to search ?");
            searchNumber = Convert.ToInt16(Console.ReadLine());
            if (linkedList.search(searchNumber) == 1)
            {
                if (linkedList.SearchAndDelete(searchNumber))
                    Console.WriteLine(searchNumber + " : deleted successfully");
                else
                    Console.WriteLine(searchNumber + " : not deleted successfully");
            }
            else
            {
                linkedList.Add(searchNumber);
            }
            linkedList.SortOrderList();
            Console.WriteLine("After Search list is :");
            linkedList.Display();
            string addFileData = linkedList.ReturnString();
            Console.WriteLine("Write :" + addFileData);
            File.WriteAllText(FILEPATH, addFileData);
        }
    }
}
