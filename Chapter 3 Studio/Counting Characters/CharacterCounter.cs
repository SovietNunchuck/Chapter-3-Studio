﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Counting_Characters
{
    class CharacterCounter
    {
        static public Dictionary<char, int> CountCharacters(string sentence)
        {
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            for (int i = 0; i < sentence.Length; i++)
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
