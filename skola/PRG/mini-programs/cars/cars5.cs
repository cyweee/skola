Console.Write("Zadej po?et aut: ");

int pocetAut = int.Parse(Console.ReadLine());



string[] nazvyAut = new string[pocetAut];
string[] cenyAut = new string[pocetAut];
string[] odpisyAut = new string[pocetAut];



for (int i = 0; i < pocetAut; i++)
{

    Console.Write("Zadej název auta na pozici ?íslo " + (i + 1) + ": ");

    nazvyAut[i] = Console.ReadLine();



    Console.Write("Zadej cenu auta na pozici ?íslo " + (i + 1) + ": ");

    cenyAut[i] = Console.ReadLine();



    Console.Write("Zadej odpis auta na pozici ?íslo " + (i + 1) + " (v %): ");

    odpisyAut[i] = Console.ReadLine();

}



Console.WriteLine();

Console.Write("Zadej po?et parametr? (minimáln? 2): ");

int pocetParametru = int.Parse(Console.ReadLine());



if (pocetParametru < 2)
{

    Console.WriteLine("Zadal jsi mén? než 2. P?idávám automaticky 'cena' a 'odpis'.");

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
for (int i = 0; i < pocetAut; i++)
    Console.Write(nazvyAut[i].PadRight(15));
Console.WriteLine();

Console.WriteLine("---------------------------------------------");

for (int i = 0; i < pocetParametru; i++)
{

    Console.Write(nazvyParametru[i].PadRight(15));
    for (int j = 0; j < pocetAut; j++) Console.Write(hodnotyParametru[i, j].PadRight(15));
    Console.WriteLine();

}



Console.ReadLine();

// AUTA3 // 

Console.WriteLine();
Console.WriteLine("Tabulka poklesu ceny oproti po?izovací cen?:");
Console.Write("Rok".PadRight(8));

for (int i = 0; i < nazvyAut.Length; i++)
{
    Console.Write(nazvyAut[i].PadRight(15));
}

Console.WriteLine();

Console.WriteLine("---------------------------------------------");





Console.Write("Zadej délku používání aut v letech: ");

int rokyPouzivani = int.Parse(Console.ReadLine());



int aktualniRok = DateTime.Now.Year;



for (int rok = 0; rok < rokyPouzivani; rok++)

{

    Console.Write($"{(aktualniRok + rok)}".PadRight(8));



    for (int i = 0; i < pocetAut; i++)
    {

        double puvodniCena = double.Parse(cenyAut[i]);

        double cenaPoRocich = puvodniCena;



        for (int r = 0; r <= rok; r++)
        {

            cenaPoRocich -= cenaPoRocich * int.Parse(odpisyAut[i]) / 100.0;

        }



        int rozdil = (int)(puvodniCena - cenaPoRocich);

        Console.Write(rozdil.ToString().PadRight(15));

    }



    Console.WriteLine();

}

// AUTA4 //
Console.WriteLine();
Console.WriteLine("Tabulka celkových náklad? za každý rok:");
Console.Write("Rok".PadRight(8));
for (int i = 0; i < pocetAut; i++)
    Console.Write(nazvyAut[i].PadRight(15));
Console.WriteLine();
Console.WriteLine("---------------------------------------------");

for (int rok = 0; rok < rokyPouzivani; rok++)
{
    Console.Write((aktualniRok + rok).ToString().PadRight(8));
    for (int i = 0; i < pocetAut; i++)
    {
        double cena = double.Parse(cenyAut[i]);
        double zbyva = cena;

        for (int r = 0; r <= rok; r++)
            zbyva -= zbyva * int.Parse(odpisyAut[i]) / 100.0;

        double rozdil = cena - zbyva;

        for (int p = 2; p < pocetParametru; p++)
            rozdil += double.TryParse(hodnotyParametru[p, i], out double val) ? val : 0;

        Console.Write(((int)rozdil).ToString().PadRight(15));
    }
    Console.WriteLine();
}

// AUTA5 //
Console.WriteLine();
Console.Write("Zadej ro?ní úrokovou sazbu investice (v %): ");
double urokovaSazba = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Tabulka ztráty z neinvestovaných pen?z:");
Console.Write("Rok".PadRight(8));
for (int i = 0; i < pocetAut; i++) Console.Write(nazvyAut[i].PadRight(15));
Console.WriteLine();
Console.WriteLine(new string('-', 10 + 15 * pocetAut));

for (int rok = 0; rok < rokyPouzivani; rok++)
{
    Console.Write((aktualniRok + rok).ToString().PadRight(8));
    for (int i = 0; i < pocetAut; i++)
    {
        double cena = double.Parse(cenyAut[i]);
        double zbyva = cena;

        for (int r = 0; r <= rok; r++)
            zbyva -= zbyva * int.Parse(odpisyAut[i]) / 100.0;

        double rozdil = cena - zbyva;

        for (int p = 2; p < pocetParametru; p++)
            if (double.TryParse(hodnotyParametru[p, i], out double val)) rozdil += val;

        double ztrata = 0;
        for (int r = 0; r <= rok; r++)
            ztrata += rozdil / Math.Pow(1 + urokovaSazba / 100.0, rokyPouzivani - r);

        Console.Write(((int)ztrata).ToString().PadRight(15));
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Tabulka celkových náklad? v?etn? ztráty úroku:");
Console.Write("Rok".PadRight(8));
for (int i = 0; i < pocetAut; i++) Console.Write(nazvyAut[i].PadRight(15));
Console.WriteLine();
Console.WriteLine(new string('-', 10 + 15 * pocetAut));

for (int rok = 0; rok < rokyPouzivani; rok++)
{
    Console.Write((aktualniRok + rok).ToString().PadRight(8));
    for (int i = 0; i < pocetAut; i++)
    {
        double cena = double.Parse(cenyAut[i]);
        double zbyva = cena;

        for (int r = 0; r <= rok; r++)
            zbyva -= zbyva * int.Parse(odpisyAut[i]) / 100.0;

        double rozdil = cena - zbyva;

        for (int p = 2; p < pocetParametru; p++)
            if (double.TryParse(hodnotyParametru[p, i], out double val)) rozdil += val;

        double ztrata = 0;
        for (int r = 0; r <= rok; r++)
            ztrata += rozdil / Math.Pow(1 + urokovaSazba / 100.0, rokyPouzivani - r);

        Console.Write(((int)(rozdil + ztrata)).ToString().PadRight(15));
    }
    Console.WriteLine();
}
