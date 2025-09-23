Console.Write("Zadej počet aut: ");
int pocetAut = int.Parse(Console.ReadLine());

string[] nazvyAut = new string[pocetAut];
string[] cenyAut = new string[pocetAut];
string[] odpisyAut = new string[pocetAut];

for (int i = 0; i < pocetAut; i++)
{
    Console.Write("Zadej název auta na pozici číslo " + (i + 1) + ": ");
    nazvyAut[i] = Console.ReadLine();

    Console.Write("Zadej cenu auta na pozici číslo " + (i + 1) + ": ");
    cenyAut[i] = Console.ReadLine();

    Console.Write("Zadej odpis auta na pozici číslo " + (i + 1) + " (v %): ");
    odpisyAut[i] = Console.ReadLine();
}

Console.WriteLine();
Console.Write("Zadej počet parametrů (minimálně 2): ");
int pocetParametru = int.Parse(Console.ReadLine());

if (pocetParametru < 2)
{
    Console.WriteLine("Zadal jsi méně než 2. Přidávám automaticky 'cena' a 'odpis'.");
    pocetParametru = 2;
}

string[] nazvyParametru = new string[pocetParametru];

if (pocetParametru >= 2)
{
    nazvyParametru[0] = "cena"; nazvyParametru[1] = "odpis";
}

for (int i = 2; i < pocetParametru; i++)
{
    Console.Write("Zadej název parametru " + (i + 1) + ": ");
    nazvyParametru[i] = Console.ReadLine();
}

string[,] hodnotyParametru = new string[100, 100];

for (int i = 0; i < pocetAut; i++)
{
    hodnotyParametru[0, i] = cenyAut[i];
    hodnotyParametru[1, i] = odpisyAut[i] + " %";
}

for (int i = 2; i < pocetParametru; i++)
{
    for (int j = 0; j < pocetAut; j++)
    {
        Console.Write("Zadej parametr '" + nazvyParametru[i] + "' pro auto '" + nazvyAut[j] + "': ");
        hodnotyParametru[i, j] = Console.ReadLine();
    }
}

Console.WriteLine();

Console.Write("Parametr:".PadRight(15));
for (int i = 0; i < pocetAut; i++) Console.Write(nazvyAut[i].PadRight(15));
Console.WriteLine();

Console.WriteLine("---------------------------------------------");

for (int i = 0; i < pocetParametru; i++)
{
    Console.Write(nazvyParametru[i].PadRight(15));
    for (int j = 0; j < pocetAut; j++) Console.Write(hodnotyParametru[i, j].PadRight(15));
    Console.WriteLine();
}

Console.ReadLine();