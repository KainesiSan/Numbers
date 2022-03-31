using System;

namespace CSharp_Shell
{
    class Calculator 
    {
        static void Main()
        {
            /* Первое число */
            double firstNumber = 0;
            
            /* Оператор */
            char sign = ' ';
            
            /* Второе число */
            double secondNumber = 0;
            
            /* Результат манипуляции над числами */
            double result = 0;
            
            try
            {
                Console.WriteLine("Введите первое число: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                
                try
                {
                    Console.WriteLine("Введите оператор (+, -, *, /, ^, √): ");
                    sign = Convert.ToChar(Console.ReadLine());
                    
                    if (sign == '+' || sign == '-' || sign == '*' || sign == '/' || sign == '^' || sign == '√')
                    {
                        try
                        {
                            Console.WriteLine("Введите второе число: ");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            
                            switch (sign)
                            {
                                case '+':
                                    result = firstNumber + secondNumber;
                                    Console.Write($"{firstNumber}{sign}{secondNumber} = {result}");
                                    break;
                                case '-':
                                    result = firstNumber - secondNumber;
                                    Console.Write($"{firstNumber}{sign}{secondNumber} = {result}");
                                    break;
                                case '*':
                                    result = firstNumber * secondNumber;
                                    Console.Write($"{firstNumber}{sign}{secondNumber} = {result}");
                                    break;
                                case '/':
                                    result = firstNumber / secondNumber;
                                    Console.Write($"{firstNumber}{sign}{secondNumber} = {result}");
                                    break;
                                case '^':
                                    result = Math.Pow(firstNumber, secondNumber);
                                    Console.Write($"{firstNumber}{sign}{secondNumber} = {result}");
                                    break;
                                case '√':
                                    result = Math.Pow(secondNumber, 1 / firstNumber);
                                    Console.Write($"{firstNumber}{sign}{secondNumber} = {result}");
                                    break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Число не может содержать буквы или спецсимволы.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого оператора не существует.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Такого оператора не существует.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Число не может содержать буквы или спецсимволы.");
            }
        }
    }
}