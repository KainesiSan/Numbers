using System;

namespace CSharp_Shell
{
    class FibonacciNumbers
    {
        static void Main()
        {
            /* Длина последовательности */
            ushort sequenceLength = 0;
            
            /* Первое число Фибоначчи */ 
            double firstNumber = 0;
            
            /* Второе число Фибоначчи */
            double secondNumber = 1;
            
            /* Сумма двух чисел Фибоначчи */
            double result = 0;
            
            /* Вывод чисел Фибоначчи */
            string output = null;
            
            try
            {
                Console.Write("Введите длину последовательности: ");
                sequenceLength = Convert.ToUInt16(Console.ReadLine());
                
                if (sequenceLength > 1476)
                {
                    output = "Длина последовательности не может быть меньше 0 или больше 1476.";
                }
                
                /* Алгоритм поиска чисел Фибоначчи */
                for (short i = 0; sequenceLength >= i && sequenceLength <= 1476; ++i)
                {
                    if (i == 0)
                    {
                        output += $"{firstNumber.ToString()} ";
                    }
                    else if (i == 1)
                    {
                        output += $"{secondNumber.ToString()} ";
                    }
                    else if (i >= 2)
                    {
                        result = firstNumber + secondNumber;
                        
                        output += $"{result.ToString()} ";
                        
                        firstNumber = secondNumber;
                        secondNumber = result;
                    }
                }
                
                Console.WriteLine(output);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Длина последовательности не может быть меньше 0 или больше 1476.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина последовательности не может содержать пустоту, буквы или спецсимволы.");
            }
        }
    }
}