using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;

namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine:
            Console.Clear();
            Console.WriteLine("Welke som wil je maken Amy-Lynn? +, -, x of :?");
            string Rekensom = Console.ReadLine();

            if (Rekensom == "+")
            {
                Console.WriteLine("Je wilt een plus som oplossen.");
                Console.WriteLine("Welk getal wil je mee beginnen?: ");
                string Plus1 = Console.ReadLine();
                Console.WriteLine("Welk getal wil je hier bij optellen");
                string Plus2 = Console.ReadLine();

                int num1 = int.Parse(Plus1);
                int num2 = int.Parse(Plus2);

                int result = num1 + num2;
                Console.WriteLine("Het antwoord is: " + result);
                Console.WriteLine($"{Environment.NewLine} Wil je nog een som maken? J/N");

                ConsoleKeyInfo cki = Console.ReadKey(intercept: true);

                if (cki.Key.ToString() == "J")
                {
                    Console.WriteLine($"{Environment.NewLine}Oke! Ik ga weer terug naar het begin: ");
                    System.Threading.Thread.Sleep(2000);
                    goto Rekenmachine;
                    //do what you need for yes
                }
                else
                {

                    Console.WriteLine("Fijn dat je me gebruikt hebt Amy-Lynn! Topper!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    // presses something other then Y
                }


            }
            else if (Rekensom == "-")
            {
                Console.WriteLine("Je wilt een min som oplossen");
                Console.WriteLine("Welk getal wil je mee beginnen?: ");
                string Min1 = Console.ReadLine();
                Console.WriteLine("Welk getal wil je hier vanaf halen?");
                string Min2 = Console.ReadLine();

                int num1 = int.Parse(Min1);
                int num2 = int.Parse(Min2);

                int result = num1 - num2;
                Console.WriteLine("Het antwoord is: " + result);
                Console.WriteLine($"{Environment.NewLine} Wil je nog een som maken? J/N");

                ConsoleKeyInfo cki = Console.ReadKey(intercept: true);

                if (cki.Key.ToString() == "J")
                {
                    Console.WriteLine($"{Environment.NewLine}Oke! Ik ga weer terug naar het begin: ");
                    System.Threading.Thread.Sleep(2000);
                    goto Rekenmachine;
                    //do what you need for yes
                }
                else
                {

                    Console.WriteLine("Fijn dat je me gebruikt hebt Amy-Lynn! Topper!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    // presses something other then Y
                }

            }

            else if (Rekensom == "x")
            {
                Console.WriteLine("Je wilt een keer som oplossen");
                Console.WriteLine("Welk getal wil je mee beginnen?: ");
                string Mult1 = Console.ReadLine();
                Console.WriteLine("Hoeveel keer wil je dit getal vermenigvuldigen?");
                string Mult2 = Console.ReadLine();

                double num1 = double.Parse(Mult1);
                double num2 = double.Parse(Mult2);

                double result = num1 *num2;
                Console.WriteLine("Het antwoord is: " + result);
                Console.WriteLine($"{Environment.NewLine} Wil je nog een som maken? J/N");

                ConsoleKeyInfo cki = Console.ReadKey(intercept: true);

                if (cki.Key.ToString() == "J")
                {
                    Console.WriteLine($"{Environment.NewLine}Oke! Ik ga weer terug naar het begin: ");
                    System.Threading.Thread.Sleep(2000);
                    goto Rekenmachine;
                    //do what you need for yes
                }
                else
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Fijn dat je me gebruikt hebt Amy-Lynn! Topper!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    
                    // presses something other then Y
                }

            }

            else if (Rekensom == ":")
            {
                Console.WriteLine("Je wilt een deel som oplossen");
                Console.WriteLine("Welk getal wil je mee beginnen?: ");
                string Div1 = Console.ReadLine();
                Console.WriteLine("Door welk getal wil je dit delen?");
                string Div2 = Console.ReadLine();

                double num1 = double.Parse(Div1);
                double num2 = double.Parse(Div2);

                double result = num1 / num2;
                Console.WriteLine("Het antwoord is: " + result);
                Console.WriteLine($"{Environment.NewLine} Wil je nog een som maken? J/N");

                ConsoleKeyInfo cki = Console.ReadKey(intercept: true);

                if (cki.Key.ToString() == "J")
                {
                    Console.WriteLine($"{Environment.NewLine}Oke! Ik ga weer terug naar het begin: ");
                    
                    goto Rekenmachine;
                    System.Threading.Thread.Sleep(2000);
                    //do what you need for yes
                }
                else
                {
                    
                    Console.WriteLine("Fijn dat je me gebruikt hebt Amy-Lynn! Topper!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    // presses something other then Y
                }

            }

            else
            {
                Console.WriteLine("Dit is geen berekening die ik ken");
                goto Rekenmachine;

            }


        }
        


       
    }
}
