Console.WriteLine("enter the first number:");

int FirstNum = int.Parse(Console.ReadLine());



Console.WriteLine("enter the operation char:");

string OpChar = System.Console.ReadLine();



System.Console.WriteLine("enter the second number:");

int SecondNum = int.Parse(Console.ReadLine());



if (OpChar == "+")
{
    Console.WriteLine(FirstNum += SecondNum);
}

else if (OpChar == "-")
{
    Console.WriteLine(FirstNum -= SecondNum);
}

else if (OpChar == "*")
{
    Console.WriteLine(FirstNum *= SecondNum);
}

else if (OpChar == "/")
{

    if (SecondNum == 0)
    {
        Console.WriteLine("You cant divide by 0");
    }

    else
    {
        Console.WriteLine(FirstNum / SecondNum);
    }

}