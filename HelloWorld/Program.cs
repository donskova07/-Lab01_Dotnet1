// // Console.WriteLine("привет от ИСП-242");
// // Console.WriteLine("автор: Донскова Ульяна");
// // Console.WriteLine("год: 2026");
// using System.Configuration.Assemblies;
// using Microsoft.VisualBasic;

// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "ульяна";
// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);
// var city = "moscow";
// var year = 2026; 
// var pi = 3.14159;
// var isActive = true;
// string myName = "ульяна";
// int myAge = 20;
// string myGroup = "ИСП-242";
// Console.WriteLine($"меня зовут {myName},мне  {myAge} лет, я учусь в группе {myGroup}.");
// Console.Write("введите ваше имя: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"привет {name2}!");
// Console.WriteLine($"через 10 лет вам будет {age + 10} лет!");
// string firstName = "ульяна";
// string lastName = "донскова";
// string group = "исп-242";
// int birthYear = 2007;
// double gpa = 4.5;
// bool hasScholarship = true;
// int currentYear = 2026;
// int age = currentYear - birthYear;
// Console.WriteLine($"студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}!");
// Console.WriteLine($"возраст: {age} лет");
// Console.WriteLine($"средний балл: {gpa}!");
// Console.WriteLine($"стипендия: {hasScholarship}");
// int a = 15;
// int b = 4;
// Console.WriteLine($"сумма: {a + b}");
// Console.WriteLine($"разность: {a - b}");
// Console.WriteLine($"произведение: {a * b}");
// Console.WriteLine($"частное (int): {a / b}");
// Console.WriteLine($"остаток: {a % b}");
// double result = (double)a / b;
// Console.WriteLine($"частное (double): {result}");
// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));
// Console.WriteLine("калькулятор");
// Console.WriteLine("введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"сумма: {num1 + num2}");
// Console.WriteLine($"разность: {num1 - num2}");
// Console.WriteLine($"произведение: {num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"частное: {num1 / num2}");
// else
//     Console.WriteLine("деление на ноль невозможно!");
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MinValue);
// Console.WriteLine("ВВЕДИТЕ ВАШЕ ИМЯ: ");
// string name = Console.ReadLine();
// Console.Write("введите вашу фамилию:");
// string surname = Console.ReadLine();
// Console.Write("введите вашу группу:");
// string group = Console.ReadLine();
// Console.Write("введите ваш год рождения:");
// int birthYear = int.Parse(Console.ReadLine());
// Console.Write("введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine());
// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;
// string status;
// if (isExcellent == true) status = "ОТЛИЧНИК";
// else status = "Хорошист";
// Console.WriteLine("ваша анкета");
// Console.WriteLine($"имя: {name} {surname}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"возраст: {age} лет");
// Console.WriteLine($"статус: {status}");
// Console.WriteLine($"лет до 30: {30 - age}!");
// Console.WriteLine("нажмите enter для выхода..");
// Console.ReadLine();


// задание1 
// using System;
// class Program
// {
//     static void Main()
//     {
//         string favgame = "CS";
//         int favnumber = 6;
//         double pi = Math.PI;
//         char fav = 'u';
//         Console.WriteLine($"любимая игра: {favgame}");
//         Console.WriteLine($"любимая цифра: {favnumber}");
//         Console.WriteLine($"знач числа пи: {pi}");
//         Console.WriteLine($"любимая буква алфавита: {fav}");

//     }
// }
//задание 2
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("i");
//         Console.WriteLine("need");
//         Console.WriteLine("more");
//         Console.WriteLine("power!");
//     }
// }
// задание 3
//  using System;
//  class Program
//  {
//      static void Main()
//      {
//     Console.WriteLine("\"Hello There\"");
// }
//  }
// задание 4
// using System; 
// class Program
// {
//     static void Main()
//     {
//         string inputMon = Console.ReadLine();
//         int mon = int.Parse(inputMon);
//         int blok = int.Parse(Console.ReadLine());
//         int klava = int.Parse(Console.ReadLine());
//         int mouse = int.Parse(Console.ReadLine());
//         int onecomp = mon + blok + klava + mouse;
//         int itog = onecomp * 3;
//         Console.WriteLine(itog);
//     }
// }
// задание 5
// using System;

// class Program
// {
//     static void Main()
//     {
//         int a = int.Parse(Console.ReadLine());
//         int b = int.Parse(Console.ReadLine());
//         int result = a * a + b; 
//         Console.WriteLine(result);
//     }
// }
