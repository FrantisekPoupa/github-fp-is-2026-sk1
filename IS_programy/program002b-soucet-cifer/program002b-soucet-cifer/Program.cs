string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("Součet cifer \n František Poupa");
    Console.WriteLine("Zadejte číslo:");
    string input = Console.ReadLine();
    int number = int.TryParse(input, out number) ? number : 0;
    int sum = 0;
    while (number < 0)
    {
        Console.WriteLine("Zadejte kladné číslo:");
        input = Console.ReadLine();
        number = int.TryParse(input, out number) ? number : 0;
    }


    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Součet cifer je: {sum}");
    Console.WriteLine("Chcete zadat další číslo? (a/n)");
    again = Console.ReadLine();
}