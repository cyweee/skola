using System;

class Program
{
    static void Main()
    {
        // ===============================
        // Cyklus 'for'
        // Opakuje se 5krát
        // ===============================
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(); // prázdný řádek pro oddělení výstupu

        // ===============================
        // Cyklus 'while'
        // Běží, dokud je podmínka splněná
        // ===============================
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine(); // prázdný řádek pro oddělení výstupu

        // ===============================
        // Příkaz 'break'
        // Ukončí cyklus, když i == 5
        // ===============================
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break; // Přerušení cyklu
            }
            Console.WriteLine(i);
        }

        Console.WriteLine(); // prázdný řádek pro oddělení výstupu

        // ===============================
        // Příkaz 'continue'
        // Přeskočí číslo 2
        // ===============================
        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                continue; // Přeskočí tento průchod
            }
            Console.WriteLine(i);
        }
    }
}
