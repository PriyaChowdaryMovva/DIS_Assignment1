using System;
using System.Text.RegularExpressions;  //Including the namespace that provides access to the Regular Expression engine

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s); //Method call
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();
        }
            

        private static String RemoveVowels(String s)
        {           
            String final_string = Regex.Replace(s, "[aeiouAEIOU]", ""); //Finding the vowels by using the regular expression pattern and replacing them with "".        
            return final_string; //Return the modified string to the main program
        }
    }
}



