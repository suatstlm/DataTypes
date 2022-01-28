using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;

            byte number1 = 255; //	0, ..., 255 (8 bit)

            short number2 = 100; //-32768, ..., 32767 (16 bit)

            int number3 = 3; //-2147483648, ..., 2147483647 (32 bit)

            long number4 = 4; //-9223372036854775808, ..., 9223372036854775807 (64  bit)

            float number5 = 11.2f; // (32 bit)

            double number6 = 5.3425; // (64 bit)
                                     
            decimal number7 = 14.453453m; //(128 bit)

            char character = 'S';

            string name = "Suat Satilmis";

            Console.WriteLine("Number1 = {0}", number1);
            Console.WriteLine("Number2 = {0}", number2);
            Console.WriteLine("Number3 = {0}", number3);
            Console.WriteLine("Number4 = {0}", number4);
            Console.WriteLine("Number5 = {0}", number5);
            Console.WriteLine("Number6 = {0}", number6);
            Console.WriteLine("Number7 = {0}", number7);
            Console.WriteLine("Condition = {0}", condition);
            Console.WriteLine("Character = {0}", character);
            Console.WriteLine("Name = {0}",name);
            Console.WriteLine(Names.Suat);



        }
        enum Names
        {
            Suat,Fuat,Umut
        }
    }
}
