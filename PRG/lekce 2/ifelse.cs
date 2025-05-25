// Příklad 1: Základní použití if
int cislo = 10;
if (cislo > 0)
{
    Console.WriteLine("Číslo je kladné.");
}

// Příklad 2: Použití if s else
int hodnota = -5;
if (hodnota > 0)
{
    Console.WriteLine("Číslo je kladné.");
}
else
{
    Console.WriteLine("Číslo není kladné.");
}

// Příklad 3: Použití else if
int teplota = 0;
if (teplota > 0)
{
    Console.WriteLine("Je nad nulou.");
}
else if (teplota < 0)
{
    Console.WriteLine("Je pod nulou.");
}
else
{
    Console.WriteLine("Teplota je přesně nula.");
}

// Příklad 4: Vnořené if
int vek = 20;
if (vek >= 18)
{
    Console.WriteLine("Jste dospělý.");
    if (vek >= 65)
    {
        Console.WriteLine("Jste v důchodu.");
    }
}
else
{
    Console.WriteLine("Nejste dospělý.");
}

