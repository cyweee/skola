Console.Write("Zadej počet aut: ");
int pocetAut = int.Parse(Console.ReadLine());

string[] nazvyAut = new string[pocetAut];
int[] cenyAut = new int[pocetAut];
int[] odpisyAut = new int[pocetAut];

for (int i = 0; i < pocetAut; i++)
{
    Console.Write("Zadej název auta na pozici číslo " + (i + 1) + ": ");
    nazvyAut[i] = Console.ReadLine();

    Console.Write("Zadej cenu auta na pozici číslo " + (i + 1) + ": ");
    cenyAut[i] = int.Parse(Console.ReadLine());

    Console.Write("Zadej odpis auta na pozici číslo " + (i + 1) + " (v %): ");
    odpisyAut[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.Write("Zadej počet let sledování: ");
int pocetLet = int.Parse(Console.ReadLine());

Console.WriteLine("\nVývoj cen aut v jednotlivých letech:");
Console.Write("Rok".PadRight(8));

for (int j = 0; j < pocetAut; j++)
{
    Console.Write(nazvyAut[j].PadRight(15));
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------");

int aktualniRok = DateTime.Now.Year;
double[,] cenyVCase = new double[100, 100];

for (int i = 0; i < pocetAut; i++)
{
    cenyVCase[0, i] = cenyAut[i];
}

for (int rok = 0; rok < pocetLet; rok++)
{
    if (rok > 0)
    {
        for (int i = 0; i < pocetAut; i++)
        {
            cenyVCase[rok, i] = cenyVCase[rok - 1, i] * (1 - odpisyAut[i] / 100.0);

            if (cenyVCase[rok, i] < 0.1) cenyVCase[rok, i] = 0;
        }
    }

    Console.Write((aktualniRok + rok).ToString().PadRight(8));

    for (int i = 0; i < pocetAut; i++)
    {
        string s = ((int)cenyVCase[rok, i]).ToString();
        Console.Write(s.PadRight(15));
    }

    Console.WriteLine();
}

Console.ReadLine();