using System;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            string operators = default;
            float a = 0;
            float b = 0;
            int? exit = null;
            Console.WriteLine("\t\t\t{0}\n",DateTime.Now);
           

            Console.WriteLine("\t\t\tWelcome Calculyator");

            while (true)
            {
 
                
                Console.WriteLine("Enter operator:");
                operators = Console.ReadLine();
                Console.WriteLine("Enter A:");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter B:");
                b = float.Parse(Console.ReadLine());


                float result = operators switch
                {
                    "+" => Add(a, b),
                    "-" => Mult(a, b),
                    "*" => Div(a, b),
                    "/" => Subt(a, b),
                    _ => 0,
                };

                Console.WriteLine("Result => {0}",result);
                
                Console.WriteLine("\t\t\t0 to exit 1 to continue");
                exit = int.Parse(Console.ReadLine());

                if(exit is 0)
                    break;
                
            }
        }


        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Mult(float a, float b)
        {
            return a - b;
        }

        public static float Div(float a, float b)
        {
            return a * b;
        }

        public static float Subt(float a, float b)
        {
            if (a != 0)
                return a / b;
            else
            {
                Console.WriteLine("A cannot be 0");
                return 0;
            }
        }
    }
}
