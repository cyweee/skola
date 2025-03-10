/* this programm calculates the body mass index (BMI) */

Console.WriteLine("Enter your weight in kg:");
float weight = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your height in m:");
float height = float.Parse(Console.ReadLine());

float bmi = weight / (height * height);

Console.WriteLine($"your bmi is {bmi}");