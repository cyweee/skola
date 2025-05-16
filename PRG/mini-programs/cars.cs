// pole nazev aut (str), pole cen (int), pole procentni pokles (int)
//    [TESLA]
//   | 2025 = 1000$ |
//   | 2026 = 1000$ - 10% = cena za 2026 |
//   | 2027 = cena za 2026 - 10% = cena za 2027 |

(string car, int price, int pokles)[] cars = {
    ("Škoda", 30000, 10),
    ("Tesla", 100000, 12),
    ("Citroën", 25000, 15)
};

Console.WriteLine($"Délka pole = {cars.Length}");
Console.WriteLine("Vyberte auto a jeho pokles v ceně:");

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cars[i].car} (Pokles: {cars[i].pokles}%)");
}

Console.Write("\nVyberte číslo auta: ");
int choice = int.Parse(Console.ReadLine()) - 1;

if (choice < 0 || choice >= cars.Length)
{
    Console.WriteLine("\nNeplatná volba, zkuste to znovu.");
    return;
}

int currentYear = DateTime.Now.Year;
var selectedCar = cars[choice];

Console.WriteLine($"\n[{selectedCar.car}]");
int currentPrice = selectedCar.price;

for (int year = currentYear; year <= currentYear + 5; year++)
{
    Console.WriteLine($"    {year} - {currentPrice}$");
    currentPrice -= currentPrice * selectedCar.pokles / 100;
}
