using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calck
{
    class Program
    {

        static void Main(string[] args)
        {


            double a;
            double b;
            double res = 0;
            char oper;

            Console.Write("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.Write("\nВведите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                res = a + b;
            }

            else if (oper == '-')
            {
                res = a - b;
            }

            else if (oper == '*')
            {
                res = a * b;
            }

            else if (oper == '/')
            {

                res = a / b;
            }
            else if (oper == '^')
            {
                res = Math.Pow(a, b);
                Console.WriteLine("Число " + a + " в степени " + b + " равно " + res + ".");
            }
            Console.WriteLine("\nРезультат: {0}", res);
            Console.ReadLine();
        }
    }
}