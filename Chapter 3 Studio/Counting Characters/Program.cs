using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*I USED THE FOLLOWING STRING PRIOR TO ATTEMPTING THE BONUS MISSIONS.
            string countThis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";*/

            Console.WriteLine("Please provide a string:\n");
            string countThis = Console.ReadLine().ToLower();

            foreach (KeyValuePair<char, int> character in CharacterCounter.CountCharacters(countThis))
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }
        }

    }
}
