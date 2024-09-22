using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in något för att kontrollera att de är Palindrom : ");

        string input = Console.ReadLine().ToLower(); // ta emot och sparar i små bokstäver

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); // delar upp strängen i ord


        // kollar alla orden
        bool foundPalindrome = false; 
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                Console.WriteLine($"'{word}' är ett palindrom");

                foundPalindrome = true;
            }
        }
        if (!foundPalindrome)
        {
            Console.WriteLine("Ingen palindrom hittades");
        }

    }
            
        //funktionen som kollar om de är en palindrom
    static bool IsPalindrome(string word)
    {

        int length = word.Length;

        for (int i = 0; i < length /2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}