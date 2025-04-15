Console.Write("Zadejte delku pole: ");
int delkaPole = int.Parse(Console.ReadLine());

int[] pole = new int[delkaPole];


for (int i = 0; i < delkaPole; i++)
{
    Console.Write($"Zadejte čislo na pozici {i + 1}: ");
    pole[i] = int.Parse(Console.ReadLine());

}


int max = pole[0];

for (int i = 1; i < delkaPole; i++)
{

    if (pole[i] > max)
    {
        max = pole[i];
    }

}


Console.WriteLine($"Největši čislo v poli je: {max}");