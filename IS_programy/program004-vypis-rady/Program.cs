string again = "a";

while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("******* Výpis řady čísel *******");
    Console.WriteLine("********************************");
    Console.WriteLine("******* František Poupa ********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first; 
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
    }
    
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo znovu: ");
    }

    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo větší než 0. Zadejte znovu: ");
    }
    
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference: {step}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    Console.WriteLine("Výpis číselné řady:");
    if (first <= last)
    {
        int current = first;
        while (current <= last)
        {
            Console.WriteLine(current);
            current += step;
        }
    }
    else
    {
        Console.WriteLine("První číslo je větší než poslední. Tento program umí vypsat pouze vzestupnou řadu (od menšího k většímu).");
    }

    again = Console.ReadLine() ?? "";
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu 'a': ");
    again = Console.ReadLine() ?? "";
}