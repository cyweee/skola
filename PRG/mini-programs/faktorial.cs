// this program calculates the factorial of a number //

Console.WriteLine("Enter a number:");
int num = Int32.Parse(Console.ReadLine());

int result = 1;
for (int i = 1; i <= num; i++)
{
    result *= i;
    Console.WriteLine($"{i}! = {result}");
}   

Console.WriteLine($"The factorial of {num} is {result}.");