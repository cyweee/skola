// pole nazev aut (str), pole cen (int), pole procentni pokles (int)
//    [TESLA]
//   | 2025 = 1000$ |
//   | 2026 = 1000$ - 10% = cena za 2026 |
//   | 2027 = cena za 2026 - 10% = cena za 2027 |

Console.Write("Zadej počet aut: ");
int carCount = int.Parse(Console.ReadLine());

string[] carNames = new string[carCount];
int[] carInitialPrices = new int[carCount];
int[] carDepreciations = new int[carCount];

for (int i = 0; i < carCount; i++)
{
    Console.Write($"Zadej název {i + 1}. auta: ");
    carNames[i] = Console.ReadLine();

    Console.Write($"Zadej cenu {i + 1}. auta: ");
    carInitialPrices[i] = int.Parse(Console.ReadLine());

    Console.Write($"Zadej roční odpis (v %): ");
    carDepreciations[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nZadej délku používání aut v letech: ");
int years = int.Parse(Console.ReadLine());


Console.WriteLine("\nVýpis cen aut podle roku:");
Console.Write("Rok".PadRight(8));
foreach (var name in carNames)
{
    Console.Write(name.PadRight(15));
}
Console.WriteLine();

Console.WriteLine(new string('-', 10 + 15 * carCount));

int currentYear = DateTime.Now.Year;

for (int year = 0; year < years; year++)
{
    Console.Write($"{(currentYear + year)}".PadRight(8));

    for (int i = 0; i < carCount; i++)
    {
        double currentPrice = carInitialPrices[i];
        for (int y = 0; y <= year; y++)
        {
            currentPrice -= currentPrice * carDepreciations[i] / 100.0;
        }

        Console.Write($"{(int)currentPrice}".ToString().PadRight(15));
    }
    Console.WriteLine();
}