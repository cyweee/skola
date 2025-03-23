// this program calculates the factorial of a number //

Console.WriteLine("Enter a number:");
int number = Int32.Parse(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Faktoriál čísla 0 neexistuje.");
}
else
{
    for (int i = 1; i <= number; i++)
    {
        int result = 1;
        string details = "";

        for (int j = 1; j <= i; j++)
        {
            result *= j;
            details += j;

            if (j != i)
            {
                details += " * ";
            }
        }

        Console.WriteLine($"{i}! = {details} = {result}");
    }
}
