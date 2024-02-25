//Программа, которая принимает на входе трехзначное число и удоляет вторую цыфру этого числа!

//int num = new Random().Next(100,1000);
//Console.WriteLine(num);
//int s = num /100*10 + num%10;
//Console.WriteLine(s);

//Программа, которая принимает на вход трехзначное число и возводит вторую цифру этого числа в степень, 
// равную третьей цифре.

//int num = new Random().Next(10,1000);
//Console.WriteLine(num);
// if(num <= 999 && num >= 100)
//{
//  int num3 = num %10;
//  int num2 = num / 10 % 10;
//Console.WriteLine(Math.Pow(num2, num3));
//}
// else
//{
// Console.WriteLine($"Число не трехзначное");
//}

//Программа, которая будет принимать на вход два числа и выводить, являеться ли второе число кратным первому
//если не кратно первому то выводить остаток от деления

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//if(num1 % num2 != 0)
//{
//    Console.WriteLine($"Число {num1} не являеться кратным {num2}! Остаток от деления: {num1 % num2}");
//}
//else
//{
//    Console.WriteLine($"Число {num2} являеться кратным {num1}!");
//}

//Программа, которая выводит третью слева цыфру заданного числа или сообщает что ее не.

//Console.Write("Введите число: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = 0;
//  if (num1 < 100)
//{
// Console.WriteLine($"Третий цифры нет");
//}
//else
//{
//    while (num1 > 100)
//    {
//        num1 /= 10;
//    }
//    Console.WriteLine(num1);
//    num2 = num1 % 10;
//    Console.WriteLine(num2);
//}

//public class Answer {
//static void CompareNumbers(int firstNumber, int secondNumber)
//{
// Введите свое решение ниже
//if (firstNumber > secondNumber)
//{
// Console.WriteLine($"Большее число: {firstNumber}");
//    }
//else if (firstNumber < secondNumber)
//{
// Console.WriteLine($"Большее число: {secondNumber}");
//}
//else 
//{
//Console.WriteLine ($"Числа равны");
//}
//}
// Не удаляйте и не меняйте метод Main! 
//static public void Main(string[] args) {
//int firstNumber, secondNumber;
//if (args.Length >= 2) {
//firstNumber = int.Parse(args[0]);
//secondNumber = int.Parse(args[1]);
//} 
//else 
//{
// Здесь вы можете поменять значения для отправки кода на Выполнение
//firstNumber = 5;
//secondNumber = 6;
//}
// Не удаляйте строки ниже
//CompareNumbers(firstNumber, secondNumber);
// }
//}

//Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое 
//число большее, а какое меньшее.
//Пример использования:На входе:firstNumber: '5'secondNumber: '6'На выходе:второе число больше На входе: 
//firstNumber: '6'secondNumber: '3'На выходе:первое число больше На входе:firstNumber: '3'secondNumber: '3'
//На выходе: числа равны

//public class Answer {
//    static void CompareNumbers(int firstNumber, int secondNumber)
//    {
//        if (firstNumber == secondNumber)
//        { 
//           Console.WriteLine($"числа равны");
//        }
//        if (firstNumber > secondNumber)
//        {
//            Console.WriteLine($"первое число больше`");
//        }
//        if (firstNumber < secondNumber)
//        {
//            Console.WriteLine($"второе число больше");
//        }
//    }
//    static public void Main(string[] args) {
//        int firstNumber, secondNumber;
//        if (args.Length >= 2) {
//            firstNumber = int.Parse(args[0]);
//            secondNumber = int.Parse(args[1]);
//        } else {
//            firstNumber = 5;
//            secondNumber = 5;
//        }
//        CompareNumbers(firstNumber, secondNumber);
//    }
//}
//Внутри класса Answer напишите метод FindMax, который принимает на вход три числа
// и выдаёт максимальное из этих чисел.

//public class Answer {
//    static int FindMax(int a, int b, int c)
//    {
//      int max = a;
//        if (max < b)
//        {
//            max = b;
//        }
//        if (max < c)
//        {
//            max = c;
//        }
//        return max;
//    }
//    static public void Main(string[] args) {
//        int a, b, c;
//        if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//        } else {
//            a = 5;
//            b = 6;
//            c = 7;
//        }
//        int result = FindMax(a, b, c);
//        System.Console.WriteLine($"{result}");
//    }
//}

//Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, 
//является ли число чётным (делится ли оно на два без остатка).
//Пример использования:
//На входе:
//number: '6'
//На выходе:
//четное
//На входе:
//number: '3'
//На выходе:
//нечетное

//class Answer {
//    static void CheckIfEven(int number)
//    {
//        if ((number % 2) == 0)
//        {
//            Console.WriteLine($"четное");
//        }
//        else
//        {
//            Console.WriteLine($"нечетное");
//        }
//    }
//    static public void Main(string[] args) {
//        int number;
//        if (args.Length >= 1) {
//            number = int.Parse(args[0]);
//        } else {
//            number = 6;
//        }
//        CheckIfEven(number);
//    }
//}

//Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
// а на выходе выводит все чётные числа от 1 до number (включительно), 
//после каждого числа должен быть знак пробела.
//На входе:
//number = 5 
//На выходе:
//2 4 
//На входе:
//number = 8 
//На выходе:
//2 4 6 8 

//public class Answer {
//    static void PrintEvenNumbers(int number)
//    {
//        for (int count = 2; count <= number; count += 2)
//        {
//            Console.Write($"{count} ");
//        }
//    }
//    static public void Main(string[] args) {
//        int number;
//        if (args.Length >= 1) {
//            number = int.Parse(args[0]);
//        } else {
//            number = 6;
//        }
//        PrintEvenNumbers(number);
//    }
//}

using Microsoft.VisualBasic;

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
//Console.WriteLine(mas);


//While
int ind = 0;
while (ind < mas.Length)
{
   Console.Write($"{mas[ind]} ");
   ind++;
}
Console.WriteLine();

//for
for (int i = 0; i < mas.Length; i++)
{
   Console.Write($"{mas[i]} ");
}
Console.WriteLine();


//foreach
foreach (var item in mas)
{
   Console.Write($"{item} ");
}
Console.WriteLine();


void Print_mas(int[] col)
{
   foreach (var item in col)
   {
      Console.Write($"{item} ");
   }
   Console.WriteLine();
}

Print_mas(mas);

//функция рандом
int[] Random_mas(int[] col)
{
   for (int i = 0; i < col.Length; i++)
   {
      col[i] = new Random().Next(1, 10);
   }
   return col;
}

int[] new_mas = Random_mas(mas);
Print_mas(new_mas);

int[] ReadLine_mas(int[] col)
{
   for (int i = 0; i < col.Length; i++)
   {
     Console.WriteLine($"Введите {i} элемент массива");
     col[i] = Convert.ToInt32(Console.ReadLine());
   }
   return col;
}

int[] new_mas2 = ReadLine_mas(mas);
Print_mas(new_mas2);

Console.Write("Введите искомое число: ");
int m = Convert.ToInt32(Console.ReadLine());

int c_R = 0;
int c_C = 0;

for (int i = 0; i < mas.Length; i++)
{
   if(new_mas[i] == m) c_R ++;
   if(new_mas2[i] ==m) c_C ++;
}
Console.WriteLine(c_R + " " + c_C);
if(c_R == 0 && c_C == 0)
{
   Console.WriteLine("Нет");
}
   else
{
  if (c_R > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas");
  if (c_C > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas2");
}