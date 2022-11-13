Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

if (A % 2 == 0)
{
    Console.WriteLine($"Число {A} - чётное");

}
else
{
    Console.WriteLine($"Число {A} - нечётное");
}


