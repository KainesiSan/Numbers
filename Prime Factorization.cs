using System;

namespace CSharp_Shell
{
    class PrimeFactorization
    {
        static void Main()
        {
            /* Число разложенное на множители */
            double number;
            
            /* Делитель */
            double divider = 2;
            
            /* Предел делителя */
            double limit;
            
            /* Вывод множителей */
            string output = null;
            
            try
            {
                Console.Write("Введите число: ");
                number = Convert.ToDouble(Console.ReadLine());
                
                limit = Convert.ToDouble(Math.Sqrt(number) + 1);
                
                while (divider < limit)
                {
                    if (number % divider == 0) 
                    {
                        if (number / divider * divider - number == 0)
                        {
                            output += divider.ToString() + "*";
                            number = number / divider;
                            limit = Convert.ToDouble(Math.Sqrt(number) + 1);
                        }
                        else
                        {
                            divider += 1;
                        }
                    }
                    else
                    {
                        divider += 1;
                    }
                }
                
                if (number == 0)
                {
                    output = "Число должно быть натуральным!";
                }
                else if (number == 1)
                {
                    output = number.ToString();
                }
                else if (output == number.ToString())
                {
                    output = $"Число {number} - простое.";
                }
                else if (output != number.ToString())
                {
                    output += number.ToString();
                }
                
                Console.WriteLine(output);
            }
            catch (FormatException)
            {
                Console.WriteLine("Число не может содержать пустоту, буквы или спецсимволы.");
            }
        }
    }
}