using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int n;
        while (true)
        {
            Console.Write("Введіть ціле число n (n > 0): ");
            string? inputN = Console.ReadLine();
            
            if (int.TryParse(inputN, out n) && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Помилка! Потрібно ввести ціле додатне число більше за 0.");
            }
        }

        int k;
        while (true)
        {
            Console.Write("Введіть ціле число k (k > 0): ");
            string? inputK = Console.ReadLine();
            
            if (int.TryParse(inputK, out k) && k > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Помилка! Потрібно ввести ціле додатне число більше за 0.");
            }
        }

        Console.WriteLine("\nОберіть номер обчислення (1, 2 або 3):");
        Console.WriteLine("1 — сума 1^n + 2^(n/2) + ... + k^(n/k)");
        Console.WriteLine("2 — сума 1^k + 2^k + ... + n^k");
        Console.WriteLine("3 — сума 1/n + 2/n^2 + 3/n^3 + ... + k/n^k");
        
        Console.Write("Ваш вибір: ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                double sum1 = 0;
                for (int i = 1; i <= k; i++)
                {
                    double exponent = (double)n / i;
                    sum1 += Math.Pow(i, exponent);
                }
                Console.WriteLine($"Результат першої суми = {sum1:F4}");
                break;

            case "2":
                double sum2 = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum2 += Math.Pow(i, k);
                }
                Console.WriteLine($"Результат другої суми = {sum2:F4}");
                break;

            case "3":
                double sum3 = 0;
                for (int i = 1; i <= k; i++)
                {
                    sum3 += (double)i / Math.Pow(n, i);
                }
                Console.WriteLine($"Результат третьої суми = {sum3:F4}");
                break;

            default:
                Console.WriteLine("Помилка: введено неіснуючий номер варіанта. Будь ласка, оберіть 1, 2 або 3.");
                break;
        }
    }
}