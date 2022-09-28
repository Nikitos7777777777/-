


while (true)
{
    Console.WriteLine("Ведите знак,+,-,*,/,^n ,корень,%,n!,9(Нажмите чтобы выйти)");
    string znak = Console.ReadLine();

    if (znak == "+")
    {
        Console.WriteLine("Введите 1 число");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        Console.WriteLine("Введите 2 число");
        string i = Console.ReadLine();
        int b = Convert.ToInt32(input);

        Console.WriteLine(a + b);
    }
    if (znak == "-")
    {
        Console.WriteLine("Введите 1 число");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        Console.WriteLine("Введите 2 число");
        string i = Console.ReadLine();
        int b = Convert.ToInt32(input);

        Console.WriteLine(a - b);
    }
    else if (znak == "*")
    {
        Console.WriteLine("Введите 1 число");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        Console.WriteLine("Введите 2 число");
        string i = Console.ReadLine();
        int b = Convert.ToInt32(input);

        Console.WriteLine(a * b);
    }
    else if (znak == "/")
    {
        Console.WriteLine("Введите 1 число");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        Console.WriteLine("Введите 2 число");
        string i = Console.ReadLine();
        int b = Convert.ToInt32(input);

        Console.WriteLine(a / b);
    }
    else if (znak == "^n")
    {
        Console.WriteLine("Введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую хотите возвести");
        int bn = Convert.ToInt32(Console.ReadLine());
        int b = a;
        for (int i = 1; i < bn; i++)
        {
            a *= b;
        }
        Console.WriteLine(a);
    }

    else if (znak == "корень")
    {
        Console.WriteLine("Введите число из которого надо найти корень");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(a));
    }
    else if (znak == "%")
    {
        Console.WriteLine("Введите число из которого нужно найти 1%");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a / 100);
    }
    else if (znak == "n!")
    {
        Console.WriteLine("Введите число");
        int a = Convert.ToInt32(Console.ReadLine());

        int f = 1;
        int i = 1;
        while (i <= a)
        {
         Console.WriteLine(f *= i);
         i++;
        }
    }
    else if (znak =="9")
    {
        break;
    }
}
