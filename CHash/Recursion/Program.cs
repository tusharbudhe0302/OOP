using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int choice;
            int first, second, last;
            while (true)
            {
                Console.WriteLine("Please select choice");
                Console.WriteLine("0. Exit From Program");
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Factorial Print Before");
                Console.WriteLine("3. Factorial Print After");
                Console.WriteLine("4. Recursive Sum Of digit");
                Console.WriteLine("5. Print decimal number to binary form");
                Console.WriteLine("6. Print decimal number to octal form");
                Console.WriteLine("7. Print decimal number to hexadecimal form");
                Console.WriteLine("8. Print n^th power");
                Console.WriteLine("9. Euclid's algorithum to find gates comman deviser (GCD)");
                Console.WriteLine("10. Fibonacci With Out Recursion");
                Console.WriteLine("11. Fibonacci With  Recursion");
                Console.WriteLine("12. Honai Puzzle");
                choice = Convert.ToInt32(Console.ReadLine());
                Recursive reccusive = new Recursive();
                BaseConversion baseConvert = new BaseConversion();
                if (choice == 0)
                {
                    Console.WriteLine("Program End...");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number <= 2)
                        {
                            Console.WriteLine("Factorial of numer : " + number + "  is : " + number);
                            break;
                        }

                        int factorialOputPut = reccusive.factorial(number);
                        Console.WriteLine("Factorial of numer " + number + " is : " + factorialOputPut);
                        break;
                    case 2:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        reccusive.factorialPrintBefore(number);
                        break;
                    case 3:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        reccusive.factorialPrintAfter(number);
                        break;
                    case 4:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        int output = reccusive.sumOfDigits(number);
                        Console.WriteLine("Number is " + output);
                        break;
                    case 5:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Binary : ");
                        baseConvert.DecimalToBinary(number);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Octal : ");
                        baseConvert.DecimalToOctal(number);
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hexadecimal : ");
                        baseConvert.DecimalToHexadecimal(number);
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Check n^th Power Of number : ");
                        int power = Convert.ToInt32(Console.ReadLine());
                        float result = baseConvert.PowerOfN(number, power);
                        Console.WriteLine("Poser on " + number + " to " + power + " is  : " + result);
                        break;
                    case 9:
                        Console.WriteLine("Please enter Dividend");
                        int dividend, divisor;
                        dividend = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Divisor");
                        divisor = Convert.ToInt32(Console.ReadLine());
                        float GCD = baseConvert.GCD(dividend, divisor);
                        Console.WriteLine("GCD : "+ GCD);
                        break;
                    case 10:
                         Console.WriteLine("Please enter First Number Of List");
                        first = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Second Number Of List");
                        second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Series last number");
                        last = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Finbonacci Series : ");
                        baseConvert.FibonacciSeries(first, second,last);
                        break;
                    case 11:
                        Console.WriteLine("Please enter First Number Of List");
                        first = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Second Number Of List");
                        second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Series last number");
                        last = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Finbonacci Series : ");
                        baseConvert.FibonacciSeriesRecusion(first, second, last);
                        break;
                    case 12:
                        Console.WriteLine("Please enter number");
                        number = Convert.ToInt32(Console.ReadLine());
                        HonaiPuzzle(number,'A' , 'B', 'C');
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            Console.ReadLine();
        }
        // Honai(n,a,b,c)
        // a - > Source
        // b -> Temp
        // c -> Destination
        static void HonaiPuzzle(int number, char source, char temp, char destination)
        {
            if (number == 1)
            {
                Console.WriteLine("Move Disk  " + number + " Move from : " + source + " --> " + destination);
                return;
            }
           //Honai(n-1, a, c,b)
            HonaiPuzzle(number - 1, source, destination, temp);
            Console.WriteLine("Move Disk " + number + " Move from : " + source + " -->  " + destination);
            //Honai(n-1, b, c,a)
            HonaiPuzzle(number - 1, temp, source, destination);
        }
    }
}
