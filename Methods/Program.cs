﻿using Methods.DZ1;
using Methods.DZ2;



namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine($"Введите слова через пробел\n\n");
            string inputText = Console.ReadLine();

            SplitText splitText = new SplitText();
            PrintConvertString printConvertString = new PrintConvertString();

            printConvertString.PrintArray(splitText.SplitInputText(inputText));*/

            //-----------------------------------------------------------------------

            Console.WriteLine($"Введите слова через пробел\n\n");
            string inputText = Console.ReadLine();

           ReversString reversString = new ReversString();
            reversString.ReversStringText(inputText);



        }
    }
}
