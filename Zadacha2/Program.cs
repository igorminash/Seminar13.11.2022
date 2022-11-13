Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int B = int.Parse(Console.ReadLine()!);

if (A > B)
{
    Console.WriteLine($"Большее число: {A}");
    Console.WriteLine($"Меньшее число: {B}");
}
else
{
    Console.WriteLine($"Большее число: {B}");
    Console.WriteLine($"Меньшее число: {A}");
}

