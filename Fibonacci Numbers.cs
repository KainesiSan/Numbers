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
                
                if (sequenceLength >= 0 && sequenceLength <= 1476)
                {
                    output += $"{firstNumber.ToString()} ";
                    
                    if (sequenceLength >= 1)
                    {
                        secondNumber = 1;
                        output += $"{secondNumber.ToString()} ";
                    }
                }
                else if (sequenceLength > 1476)
                {
                    Console.WriteLine("Длина последовательности не может быть меньше 0 или больше 1476.");
                }
                
                for (short a = 1; sequenceLength > a && sequenceLength <= 1476; ++a)
                {
                    result = firstNumber + secondNumber;
                    
                    output += $"{result.ToString()} ";
                    
                    firstNumber = secondNumber;
                    secondNumber = result;                
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