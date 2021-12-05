// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


calculator calc = new calculator();
int result = calc.Add();
calc.x = 10;
calc.y = 20;
Console.WriteLine(result);