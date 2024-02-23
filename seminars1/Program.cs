//# Домашка #
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//if(num1 % 7 == 0)
//if(num2 % 23 == 0)
//{
//    Console.WriteLine($"Число {num1} не являеться кратным {num2}!");
//}
//else
//{
//    Console.WriteLine($"Число {num2} являеться кратным {num1}!");
//}

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

//Console.Write("Введите координаты точки X и Y через пробел: ");
//string[] coordinates = Console.ReadLine().Split(' ');

//int x = Convert.ToInt32(coordinates[0]);
//int y = Convert.ToInt32(coordinates[1]);
//if (x > 0 && y > 0)
//Console.WriteLine("1");
//else if (x < 0 && y > 0)
//Console.WriteLine("2");
//else if (x < 0 && y < 0)
//Console.WriteLine("3");
//else if (x > 0 && y < 0)
//Console.WriteLine("4");
//else if (x > 0 && y > 0)
//Console.WriteLine("Точка находится на оси координат");

//Напишите программу, которая принимает на вход целое
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Console.Write("Введите число из отрезка [10, 99]: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;Console.WriteLine(maxDigit);


//Напишите программу, которая на вход принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

int i = 1;
while (i < 10)
{
     Console.Write($"{i}, ");
     i++;
}
Console.Write("\b\b ");