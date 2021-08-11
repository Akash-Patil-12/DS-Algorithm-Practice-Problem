using System;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int choice;
            //constants
            const int PERMUTATION = 1, BINARY = 2, INSERTION = 3, BUBBLE = 4,ANAGRAM=6,PRIMENUMBER=7,PRIME_PALINDROME=8,UNORDERED_LIST=13,ORDERED_LIST=14,BALANCED_PARENTHESES=15,BANKCASH=16,PALINDROME_CHECKER=17;
            while (true)
            {
                Console.WriteLine("***************Main Manu****************");
                Console.WriteLine("1 : Permutation");
                Console.WriteLine("2 : Binary Search");
                Console.WriteLine("3 : Insertion Sort");
                Console.WriteLine("4 : Bubble Sort");
                Console.WriteLine("6 : Anagram Detection Example");
                Console.WriteLine("7 : Prime Number");
                Console.WriteLine("8 : Prime Number that are Palindrome and Anagram");
                Console.WriteLine("13 : Unordered List");
                Console.WriteLine("14 : Ordered List");
                Console.WriteLine("15 : Balanced Parentheses");
                Console.WriteLine("16 : Banking Cash Counter");
                Console.WriteLine("17 : Palindrome checker");
                Console.WriteLine("****************************************");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case PERMUTATION:
                        Permutation permutation = new Permutation();
                        Console.WriteLine("Enter a string");
                        string stringPermutation = Console.ReadLine();
                        permutation.PrintPermutation(stringPermutation,"");
                        break;
                    case BINARY:
                        SearchWorldFromWorldList searchWorldFromWorldList = new SearchWorldFromWorldList();
                        searchWorldFromWorldList.SearchWorld();
                        break;
                    case INSERTION:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.InsertionSortMethod();
                        break;
                    case BUBBLE:
                        Bubble bubble = new Bubble();
                        bubble.BubbleSort();
                        break;
                    case ANAGRAM:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case PRIMENUMBER:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumberInRange();
                        break;
                    case PRIME_PALINDROME:
                        Number_Anagram_Palindrome number_Anagram_Palindrome = new Number_Anagram_Palindrome();
                        number_Anagram_Palindrome.PrimeNumberInRange();
                        break;
                    case UNORDERED_LIST:
                        UnOrderedList unOrderedList = new UnOrderedList();
                        unOrderedList.Operation();
                        break;
                    case ORDERED_LIST:
                        OrderList orderList = new OrderList();
                        orderList.Operation();
                        break;
                    case BALANCED_PARENTHESES:
                        BalancedParentheses balancedParentheses = new BalancedParentheses();
                        balancedParentheses.CheckBalancedParentheses();
                        break;
                    case BANKCASH:
                        BankingCashCounter bankingCashCounter = new BankingCashCounter();
                        bankingCashCounter.BankATM();
                        break;
                    case PALINDROME_CHECKER:
                        PalindromeChecker palindromeChecker = new PalindromeChecker();
                        palindromeChecker.CheckPalindrome();
                        break;
                    default:
                        Console.WriteLine("Enter a right choice");
                        break;
                }
                Console.WriteLine("Press Y or y to continue");
                char choiceContinue =Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if (choiceContinue != 'y')
                    break;
            }
        }
    }
}
