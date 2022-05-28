// See https://aka.ms/new-console-template for more information
Console.Write("Введите коэффициенты K и B первой функции через пробел :");
float [] first = Console.ReadLine().Split().Select(float.Parse).ToArray();
Console.Write("Введите коэффициенты K и B второй функции через пробел :");
float[] sec = Console.ReadLine().Split().Select(float.Parse).ToArray();
float x = (sec[1] - first[1])/(first[0]-sec[0]);
float y  = first[0] * x + first[1];
Console.WriteLine();
Console.WriteLine($"x = {x}; y = {y}");


