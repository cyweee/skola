Console.WriteLine("Zadej velikost pole: ");
int size;
size = int.Parse(Console.ReadLine());



int[] numbers = new int[size];
int sum = 0;



for (int i = 0; i < size; i++)
{
    Console.Write($"Zadej čislo na pozici {i}: ");
    numbers[i] = int.Parse(Console.ReadLine());
    sum += numbers[i];
}



Console.WriteLine("\nObsah pole:");

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Pozice {i} = {numbers[i]}");
}



Console.WriteLine($"Součet pole je {sum}");