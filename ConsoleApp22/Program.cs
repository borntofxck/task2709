using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1000 && number <= 9999)
                {
                    int digitSum = 0;
                    int digitProduct = 1;
                    int tempNumber = number;

                    while (tempNumber != 0)
                    {
                        int digit = tempNumber % 10;
                        digitSum += digit;
                        digitProduct *= digit;
                        tempNumber /= 10;
                    }

                    bool conditionResult = digitSum > digitProduct;
                    Console.WriteLine(conditionResult ? "true" : "false");
                }
                else
                {
                    Console.WriteLine("Введено нечетырёхзначное число.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число.");
            }
        }
        
        }
    }

