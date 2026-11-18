using System.Drawing;

string again = "a";

while (again.ToLower() == "a")
{
    Console.Write("Zadejte velikost trojúhelníku: ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
    {
        Console.Write("Kladné celé číslo větší než 0, zadejte velikost znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Trojuhelník o velikosti {size}:");
    Console.WriteLine();

    // Tvůj epický cyklus s mojí úpravou
    for (int i = 1; i <= size; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(50);
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}