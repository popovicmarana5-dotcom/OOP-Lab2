using System;
class Program
{
    static void Main (string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double x = 0, y = 0, z = 0;

        while (true)
        {
            Console.WriteLine("Введіть дробове значення x = ");
            string?input = Console.ReadLine();
            if (double.TryParse(input, out x))
            {
                break;
            } 

            else
            {
            Console.WriteLine("Введено некоректне значення. Спробуйте ще раз.");
            }
        }
            
            while (true)
            {
                Console.WriteLine("Введіть дробове значення y = ");
                string?input = Console.ReadLine();
                if (double.TryParse(input, out y))
                {
                    break;
                }
                 
                else
                {
                Console.WriteLine("Введено некоректне значення. Спробуйте ще раз.");
                }
            }

            while (true)
            {
                Console.WriteLine("Введіть дробове значення z = ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out z))
                {
                    break;
                }
                
                else
                {
                    Console.WriteLine("Введено некоректне значення. Спробуйте ще раз.");
                }
            }

            try
            {
                double numerator = 2 * Math.Cos(x * x) - (1.0 / Math.Sqrt(2)) + Math.Exp(z);

                 double denominator = (2.0 / 3.0) + Math.Sin(Math.Pow(y, 2-z));

                 if (denominator == 0)
            {
                Console.WriteLine("Помилка: знаменник дорівнює нулю. Обчислення неможливе.");
                return;
            }

            double s = numerator / denominator;
            s = Math.Round(s, 3);
            Console.WriteLine($"Результат обчислення: s = {s}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Помилка під час обчислення: {ex.Message}");
        }
    }
}