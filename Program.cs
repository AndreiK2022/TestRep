Console.WriteLine("Введите элементы массива через пробел: ");
string[] array = Console.ReadLine()!.Split(" ").ToArray();
foreach (var element in array)
{
    if (element.Length <= 3)
    {
        Console.Write($"{element} ");
    }
    else
    {
        Console.Write("");
    }
}