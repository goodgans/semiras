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


int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 % 7 == 0)
if(num2 % 23 == 0)
{
    Console.WriteLine($"Число {num1} не являеться кратным {num2}!");
}
else
{
    Console.WriteLine($"Число {num2} являеться кратным {num1}!");
}