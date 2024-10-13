namespace HSE_LAB1_1;
class Program
{
    static void Main(string[] args)
    {
        int n;
        int m;
        double x;
        bool isNumber;

        int expression1;
        bool expression2;
        bool expression3;

        Console.WriteLine("Эта программа вычисляет некоторые математические выражения:\n\n++n * ++m\nm++ < n\nn++ > m\nx + 1/(x^3 - x) - 2\n");
        Console.Write("Введите целое число n: ");
        do
        {
            isNumber = Int32.TryParse(Console.ReadLine(), out n);
            if (!isNumber) Console.Write("Введено неверное число, попробуйте еще раз.\n\nВведите целое число n: ");
        }
        while (!isNumber);

        Console.Write("\nВведите целое число m: ");
        do
        {
            isNumber = Int32.TryParse(Console.ReadLine(), out m);
            if (!isNumber) Console.Write("Введено неверное число, попробуйте еще раз.\n\nВведите целое число m: ");
        }
        while (!isNumber);

        Console.Write("\nВведите вещественное число x: ");
        do
        {
            isNumber = double.TryParse(Console.ReadLine(), out x);
            if (!isNumber) Console.Write("Введено неверное число, попробуйте еще раз.\n\nВведите вещественное число x: ");
        }
        while (!isNumber);
        
        expression1 = ++n * ++m;
        Console.WriteLine($"\n1) ++n * ++m = {expression1}");
        Console.WriteLine($"Значения переменных: n = {n}, m = {m}\n");
        
        expression2 = m++ < n;
        Console.WriteLine($"2) m++ < n = {expression2}");
        Console.WriteLine($"Значения переменных: n = {n}, m = {m}\n");
        
        expression3 = n++ > m;
        Console.WriteLine($"3) n++ > m = {expression3}");
        Console.WriteLine($"Значения переменных: n = {n}, m = {m}\n");
        
        Console.WriteLine((x * x * x - x != 0) ? $"x + 1/(x^3 - x) - 2 = {x + 1 / (x * x * x - x) - 2}" : "Выражение не определено, деление на 0 невозможно");
        Console.ReadKey();
    }
}
