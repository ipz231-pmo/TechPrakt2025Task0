
double num1, num2;

while(true)
{
    Console.Write("Enter first number: ");
    string? tmp = Console.ReadLine();
    if (double.TryParse(tmp, out num1)) break;
    Console.WriteLine("Error. Failed to parse string to number. Please try again.");
}

while (true)
{
    Console.Write("Enter second number: ");
    string? tmp = Console.ReadLine();
    if (double.TryParse(tmp, out num2)) break;
    Console.WriteLine("Error. Failed to parse string to number. Please try again.");
}


Console.WriteLine($"Sum is {num1 + num2}");
