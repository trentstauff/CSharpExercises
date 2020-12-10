using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithText
{
    class ToPascalCase
    {
        // 4- Write a program and ask the user to enter a few words separated by a space. 
        // Use the words to create a variable name with PascalCase. For example, 
        // if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
        // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public static string toPascalCase(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                {
                    return "Sentence is invalid.";
                }
            }

            var stringArray = text.Split(" ");
            var builder = new StringBuilder();

            foreach (var tempString in stringArray)
            {
                for (var j = 0; j < tempString.Length; j++)
                {
                    if (j == 0)
                    {
                        builder.Append(tempString[j].ToString().ToUpper());
                        continue;
                    }

                    builder.Append(tempString[j].ToString().ToLower());
                }
            }

            return builder.ToString();
        }
    }
}
