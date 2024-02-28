//# Домашка #
// 1 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

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

// 2 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
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

// 3 Напишите программу, которая принимает на вход целое
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Console.Write("Введите число из отрезка [10, 99]: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;Console.WriteLine(maxDigit);


// 4 Напишите программу, которая на вход принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

//int i = 1;
//while (i < 10)
//{
//     Console.Write($"{i}, ");
//     i++;
//}
//Console.Write("\b\b ");



// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения
// которых лежат в отрезке [10,90]. Начальные условия:int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// Создание массива Выводится: 5
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        int cnt = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= minRange && numbers[i] <= maxRange)
            {
                cnt++;
            }
        }
        return cnt;
    }
    public static void PrintResult(int[] array)
    {
        Console.WriteLine(CountItemsRange(array, 10, 90));
    }
}
//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);
            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            // Теперь arr содержит преобразованные в целые числа из командной строки
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}

//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
//Начальные условия: int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//Выводится: 6

{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        int cnt = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                cnt++;
            }
        }
        return cnt;
    }
    public static void PrintResult(int[] array)
    {
        Console.WriteLine(CountEvenItems(array));
    }
}
//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);
            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            // Теперь arr содержит преобразованные в целые числа из командной строки
        } else {
           // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}