using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // use try and catch to avoid errors or crash
            try
            {
                // use checked wrap to avoid overflowing
                checked
                {
                    byte number = 255;
                    number = ++number;
                    Console.WriteLine(number);
                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // input "cw" then press Tab to input following code in shortcut way
            Console.WriteLine("Hello World!");

            // Ctrl + Shift + B for compile the program
            // Ctrl + F5 for run the program
            // Ctrl + x to delete one whole line

            byte num = 8;
            int leaf = 98;
            float unitPrice = 21.12f;
            string name = "Book";
            char character = 'Y';
            bool boola = true;
            const long largeNum = 9999999999999999;

            Console.WriteLine(num);
            Console.WriteLine(leaf);
            Console.WriteLine(unitPrice);
            Console.WriteLine(name);
            Console.WriteLine(character);
            Console.WriteLine(boola);
            Console.WriteLine(largeNum);

            Console.WriteLine("byte type has MaxValue of {0} and MinValue of {1}.", 
                byte.MaxValue, byte.MinValue);

            
        }
    }
}
