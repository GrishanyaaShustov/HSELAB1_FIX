namespace HSELAB1_3;

class Program
{
    static void Main(string[] args)
    {
        const double a = 1000;
        const double b = 0.0001;

        const float af = 1000f;
        const float bf = 0.0001f;

        double p1;
        double p2;
        double p3;
        double result;

        float p1f;
        float p2f;
        float p3f;
        float resultf;
        
        // Вычисление в типе double
        p1 = (a - b) * (a - b);
        p2 = (a * a - 2 * a * b);
        p3 = b * b;
        result = (p1 - p2) / p3;

        Console.WriteLine($"(a-b)^2 = {p1}");
        Console.WriteLine($"a^2 - 2*a*b = {p2}");
        Console.WriteLine($"b^2 = {p3}");
        Console.WriteLine($"Результат = {result}\n");
        
        // Вычисление в типе float
        p1f = (af - bf) * (af - bf);
        p2f = (af * af - 2 * af * bf);
        p3f = bf * bf;
        resultf = (p1f - p2f) / p3f;
        
        Console.WriteLine($"(a-b)^2 = {p1f}");
        Console.WriteLine($"a^2 - 2*a*b = {p2f}");
        Console.WriteLine($"b^2 = {p3f}");
        Console.WriteLine($"Результат = {resultf}");


    }
}
