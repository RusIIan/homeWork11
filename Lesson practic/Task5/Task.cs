using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practic.Task5
{
    public  class Task5
    {
        static void Main()
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    Console.Write(text[i]);
                }
            }

        }
    }
}
