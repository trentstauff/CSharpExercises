using System;

namespace WorkingWithText
{
    class Duplicate
    {
        // 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        // If the user simply presses Enter, without supplying an input, exit immediately; 
        // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
        public static string duplicate(string text = null)
        {
            if (text == null)
            {
                text = Console.ReadLine();
                if (String.IsNullOrEmpty(text))
                {
                    return "String empty.";
                }
            }

            var stringArray = text.Split("-");

            // runtime could be improved with a hashtable,
            // simply iterate and count occurances of
            // numbers, if < 1, duplicates.

            for(var i = 0; i < stringArray.Length; i++)
            {
                for (var j = i; j < stringArray.Length; j++)
                {
                    if (i == j) continue;
                    if (stringArray[i] != stringArray[j]) continue;
                    return "Duplicate Element Found.";
                }
            }

            return "No Duplicate Elements.";
        }
    }
}
