int[] pole = { 12, 9, 32, 21, 17 };

Console.WriteLine("před");
for (int i = 0; i < pole.Length; i++)
{
    Console.Write(pole[i] + " ");
}

Console.WriteLine("\n-----------");

for (int i = 0; i < pole.Length; i++)
{
    for (int j = 0; j < pole.Length - 1; j++)
    {
        if (pole[j] > pole[j + 1])
        {
            int a = pole[j];
            pole[j] = pole[j + 1];
            pole[j + 1] = a;
        }
    }
}

Console.WriteLine("potom");
for (int i = 0; i < pole.Length; i++)
{
    Console.Write(pole[i] + " ");
}

Console.ReadLine();