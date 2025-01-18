try
{
    Console.WriteLine("Въведете коефициента a:");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Въведете коефициента b:");
    int b = int.Parse(Console.ReadLine());

    if (b <= 0)
    {
        if (a >= 0)
            Console.WriteLine("Няма реални решения");
        else
        {
            double root = Math.Sqrt(b / a);

            Console.WriteLine($"Решенията са (-inf; {-root:f2}) U ({root:f2}; +inf)");
        }
    }
    else
    {
        if (a <= 0)
            Console.WriteLine("Всички реални числа са решения");
        else
        {
            double root = Math.Sqrt(b / a);

            Console.WriteLine($"Решенията са ({-root:f2}; {root:f2})");
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Некоректно въведено число");
}
