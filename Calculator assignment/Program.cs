using System;

namespace Calculator_assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int x = 0; x < int.MaxValue; x++)

            {
                Console.WriteLine("Please insert c to clear the page!");

                Console.WriteLine("please insert + ,- ,* ,/  as operators! ");

                string op = Console.ReadLine();


                switch (op)
                {
                    case "+":
                        {
                            Console.WriteLine("please insert number 1:");
                            double number1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("please insert number 2:");

                            double number2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("{0}+{1}= {2}", number1, number2, number1 + number2);

                            break;
                        }



                    case "-":
                        {
                            Console.WriteLine("please insert number 1:");
                            double number1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("please insert number 2:");
                            double number2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("{0}-{1}= {2}",number1 ,number2 , number1 - number2);

                            break;
                        }

                    case "*":
                        {
                            Console.WriteLine("please insert number 1:");
                            double number1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("please insert number 2:");
                            double number2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("{0}*{1}= {2}", number1, number2, number1 * number2);

                            break;
                        }

                    case "/":
                        {
                            Console.WriteLine("please insert number 1:");
                            double number1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("please insert number 2:");
                            double number2 = double.Parse(Console.ReadLine());
                            if (number2 == 0)
                            {
                                Console.WriteLine( "Invalid Number");
                            }
                            else

                                Console.WriteLine("{0}/{1}= {2}", number1, number2, number1 / number2);

                            break;
                        }

                    case "c":
                        {
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        }




                }
            }
                
                
            Console.ReadKey();
        }
    }
}
