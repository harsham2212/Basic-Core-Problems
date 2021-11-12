using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Problems
{
    class CheckConsonantVowel
    {
        public void VowelsConsonant()
        {
            Console.WriteLine("enter character");
            char alphabet = Convert.ToChar(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("entered character is vowel");
            }
            else
                Console.WriteLine("entered character is consonant");
        }        
    }
}
