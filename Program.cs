Console.WriteLine("Введите элементы массива через пробел: ");
string[] array = Console.ReadLine()!.Split(" ").ToArray();

List<string> elements = new List<string>();

foreach (var element in array)
{
    if (element.Length <= 3)
    {
        elements.Add(new string(element));
    }
}

string[] newArray = elements.ToArray();
foreach (var item in newArray)
{
    Console.Write($"{item} ");
}