using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9._СамРабота._Обработка_исключений
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            //int operation;
            
            Console.WriteLine("Вас приветствует калькулятор!");

            Console.Write("Введите целое число.  X=");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);

            }
            Console.Write("Введите целое число.  Y=");
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);

            }
            Console.WriteLine("Введите код операции");
            Console.WriteLine("1 – сложение"); 
            Console.WriteLine("2 – вычитание");
            Console.WriteLine("3 – произведение");
            Console.WriteLine("4 – частное");
            try
            {
                Console.Write("Ваш выбор: ");
                int operation = Convert.ToInt32(Console.ReadLine());
                
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Результат:" + (num1 + num2));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Результат:" + (num1 - num2));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Результат:" + (num1 * num2));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Результат:" + (num1 / num2));
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Недопустимый код операции");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}