int[] numbers = { 5, 2, 8, 1, 3 };

Console.WriteLine("Původní pole:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

Array.Sort(numbers);

Console.WriteLine("Seřazené pole:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();