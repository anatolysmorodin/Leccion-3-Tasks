// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. (читается слева направо и справа налево одинаково)

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;

if (number[0] == number[4] && number[1] == number[3]) 
{
    Console.WriteLine("string number - число палиндром");
}
else 
{
    Console.WriteLine("string number - не число палиндром");
}


