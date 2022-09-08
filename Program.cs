using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RekenmachineAmy
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int min = 0;
                int max = 4;
                int inputValue;

            Start:
                Console.WriteLine("Welke som wil je oplossen Amy-Lynn?");
                Console.WriteLine("Toets 1 voor een + Som ");
                Console.WriteLine("Toets 2 voor een - som ");
                Console.WriteLine("Toets 3 voor een : som ");
                Console.WriteLine("Toets 4 voor een x som ");

                string prompt = $"Toets het getal nu in: ({min}-{max}): ";

                Console.Write(prompt);
                while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < min || max < inputValue)
                {
                    Console.WriteLine("Verkeerd gekozen... probeer het opnieuw.");
                    Console.Write(prompt);
                }

                if (inputValue == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Je wil een + som maken!");

                    // Plus Som
                    Console.WriteLine($"{Environment.NewLine} Voer het eerste getal in:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{Environment.NewLine} Voer het getal in wat je er bij wil optellen:");
                    int num2 = Convert.ToInt32(Console.ReadLine()); //int to int
                    double antwoordop = num1 + num2;
                    Console.WriteLine($"{Environment.NewLine} Het antwoord op de som " + (num1) + " + " + (num2) + " = " + antwoordop);
                    goto Somklaar;
                }

                else if (inputValue == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Je wil een - som maken!");
                    // Min Som
                    Console.WriteLine($"{Environment.NewLine} Voer het eerste getal in:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{Environment.NewLine} Voer het getal in wat je er vanaf wil halen:");
                    int num2 = Convert.ToInt32(Console.ReadLine()); //int to int
                    double antwoordmin = num1 - num2;
                    Console.WriteLine($"{Environment.NewLine} Het antwoord op de som " + (num1) + " - " + (num2) + " = " + antwoordmin);
                    goto Somklaar;

                }
                else if (inputValue == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Je wil een : som maken!");
                    Console.WriteLine($"{Environment.NewLine} Voer het eerste getal in:");
                    float num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{Environment.NewLine} Voer het getal in wat je wil delen:");
                    float num2 = Convert.ToInt32(Console.ReadLine()); //int to int
                    double antwoordkeer = num1 / num2;
                    Console.WriteLine($"{Environment.NewLine} Het antwoord op de som " + (num1) + " : " + (num2) + " = " + antwoordkeer);
                    goto Somklaar;
                    Console.Clear();
                }

                else if (inputValue == 4)
                {
                    // X Som
                    Console.WriteLine("Je wil een x som maken!");
                    Console.WriteLine($"{Environment.NewLine} Voer het eerste getal in:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{Environment.NewLine} Voer het getal in waar mee je de keer som wil maken:");
                    int num2 = Convert.ToInt32(Console.ReadLine()); //int to int

                    double antwoordkeer = num1 * num2;
                    Console.WriteLine($"{Environment.NewLine} Het antwoord op de som " + (num1) + " x " + (num2) + " = " + antwoordkeer);
                    goto Somklaar;
                    Console.Clear();
                }
            Somklaar:
                //Som klaar!
                Console.WriteLine($"{Environment.NewLine} Wil je nog een som maken Amy-Lynn? J/N");

                ConsoleKeyInfo cki = Console.ReadKey(intercept: true);

            Opnieuw:
                if (cki.Key.ToString() == "J")
                {
                    Console.WriteLine($"{Environment.NewLine} Oke! Ik ga weer terug naar het begin: ");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    goto Start;
                    //do what you need for yes
                }
                if (cki.Key.ToString() == "N")
                {
                    Console.WriteLine($"{Environment.NewLine} Fijn dat je me gebruikt hebt Amy-Lynn! Topper!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    // presses something other then Y
                }

            }
        }
    }
}