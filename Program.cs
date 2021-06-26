using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj pierwsza liczbe:");
                var number1 = GetInput();


                //if (!int.TryParse(Console.ReadLine(), out int number1))
                    //throw new Exception("Podana wartosc jest nieprawidlowa.");

                Console.WriteLine("Jaka operacje chcesz wykonac? MOzliwe operacje to '+','-','/','*'.");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj druga liczbe:");
                var number2 = GetInput();
                //if (!int.TryParse(Console.ReadLine(), out int number2))
                    //throw new Exception("Podana wartosc jest nieprawidlowa.");

                var result = Calculate(number1, number2, action);

                Console.WriteLine("Wynik twojego dzialania to: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                    throw new Exception("Podana wartosc jest nieprawidlowa.");
            return input;
        }
        private static int Calculate(int number1, int number2, string action)
        {
            return action switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "/" => number1 / number2,
                "*" => number1 * number2,
                _ => throw new Exception("Wybrales zla operacje."),
            };           
        }
    }
}
            
