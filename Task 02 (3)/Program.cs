// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите первое число: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int x3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите шестое число: ");
int y3 = int.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow (y1 - x1,2) + Math.Pow (y2 - x2,2) + Math.Pow (y3 - x3,2));

Console.WriteLine(ab);