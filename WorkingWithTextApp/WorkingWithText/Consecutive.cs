using System;

namespace WorkingWithText
{
    public class Consecutive
    {
        // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
        // display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static string isConsecutive(string text = null)
        {
            if (text == null)
            {
                text = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Input invalid.");
                    return null;
                }
            }

            var textArray = text.Split("-");
            var firstNum = Convert.ToInt32(textArray[0]);
            var secondNum = Convert.ToInt32(textArray[1]);
           
            if (secondNum - firstNum == 1)
            {
                // possible increment
                var prev = firstNum;
                var count = 0;

                foreach (var number in textArray)
                {
                    if (count == 0)
                    {
                        count++;
                        continue;
                    }

                    var curr = Convert.ToInt32(number);

                    if (curr - prev != 1)
                        return "Not Consecutive";

                    prev = curr;
                    count++;
                }

                return "Consecutive";
            }
            else if(secondNum - firstNum == -1)
            {
                // possible decrement
                var prev = firstNum;
                var count = 0;

                foreach (var number in textArray)
                {
                    if (count == 0)
                    {
                        count++;
                        continue;
                    }
                    
                    var curr = Convert.ToInt32(number);

                    if (curr - prev != -1)
                        return "Not Consecutive";

                    prev = curr;
                    count++;
                }
                return "Consecutive";
            }
            else
            {

            }
            return "Not Consecutive";
        }
    }
}
