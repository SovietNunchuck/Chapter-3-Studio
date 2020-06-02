using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string countThis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            foreach (KeyValuePair<char, int> character in CountCharacters(countThis))
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }
            //Console.WriteLine(CountCharacters(countThis));
        }

        static Dictionary<char, int> CountCharacters(string sentence)
        {
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            for (int i=0; i < sentence.Length; i++)
            {
                char currentCharacter = sentence[i];
                if (!characterCounts.ContainsKey(currentCharacter))
                {
                    characterCounts.Add(currentCharacter, 1);
                }
                else
                {
                    characterCounts[currentCharacter]++;
                }
            }
            return characterCounts;
        }
    }
}
