Console.Clear();

Console.Write("Введите номер четверти координатной плоскости: ");
int quarter = int.Parse(Console.ReadLine()!);

while (quarter < 1 || quarter > 4)
{
    Console.Write("Введите номер четверти координатной плоскости: ");
    quarter = int.Parse(Console.ReadLine()!);
}

if (quarter == 1)
{
    Console.WriteLine("X > 0 и Y > 0");
}

else if (quarter == 2)
{
    Console.WriteLine("X < 0 и Y > 0");
}

else if (quarter  == 3)
{
    Console.WriteLine("X < 0 и Y < 0");
}

else if (quarter == 4)
{
    Console.WriteLine("X > 0 и Y < 0");
}

