using System;

namespace Calculator_assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please insert + ,- ,* ,/  as operators! ");

            string strnumber1 = Console.ReadLine();
            string op = Console.ReadLine();
            string strnumber2 = Console.ReadLine();
            double number1 = Convert.ToDouble(strnumber1);
            double number2 = Convert.ToDouble(strnumber2);


            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiply = number1 * number2;
            double division = number1 / number2;



            switch (op)
            {
                case "+":
                    Console.WriteLine(addition);
                    break;

                case " - ":
                    Console.WriteLine(subtraction);
                    break;

                case "*":
                    Console.WriteLine(multiply);
                    break;

                case "/":
                    Console.WriteLine(division);
                    break;



            }
            Console.ReadKey();
        }
    }
}
