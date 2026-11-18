string again = "a";
Console.WriteLine("Vykreslení obrazce");
while (again.ToLower() == "a")
{
    Console.Write("Zadejte šířku obrazce: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.Write("Zadejte výšku obrazce: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Obrazec o rozměrech {width} × {height}:");
    Console.WriteLine();

    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}