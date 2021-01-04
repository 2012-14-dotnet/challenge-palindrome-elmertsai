using System;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UserView();
        }
        static void UserView()
        {
            var input = "";
            bool done = false;
            Console.WriteLine("Welcome to the Palindrome Checker Challenge!");
            while(!done)
            {
                Console.WriteLine("Please enter a word to check if it's a palindrome or not!");
                input = Console.ReadLine();
                if(IsPalindrome(input) == true)
                {
                    Console.WriteLine(input + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine(input + " is not a Palindrome!");
                }
                done = ContinueOrStop();
            }
                
        

        }

        static bool ContinueOrStop()
        {
            bool done = false;
            int input = 0;

            while(!done)
            { 
                Console.WriteLine("Enter 1 to continue, 2 to stop. ");
                int.TryParse(Console.ReadLine(), out input);
                if(input == 1)
                {
                    return false;
                }
                else if(input ==2)
                {
                    Console.WriteLine("Exiting Program...");
                    return true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice (number 1 or 2)");
                }
            }
            Console.WriteLine("Something went wrong in ContinueOrStop method");
            return true;
        }
        static bool IsPalindrome(string s)
        {
            int length = s.Length;
            s = s.ToLower();
            for(int i=0; i<length/2; i++)
            {
                if(s[i] != s[length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
