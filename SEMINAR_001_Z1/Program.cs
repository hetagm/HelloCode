// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int kvadrat = num2 * num2;

// if(num1 == kvadrat)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else 
// {
//     Console.WriteLine("Первое число НЕ является квадратом второго");
// }

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while (current <= num)
// {
//     Console.Write(current);
//     current = current +1;
// }

// Задача. Консольный ввод параметров

// Console.Write("Введите имя: ");
// string? name = Console.ReadLine();
 
// Console.Write("Введите возраст: ");
// int age = Convert.ToInt32(Console.ReadLine());
 
// Console.Write("Введите рост: ");
// double height = Convert.ToDouble(Console.ReadLine());
 
// Console.Write("Введите размер зарплаты: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine());
 
// Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");


// Задача. Сравнение двух чисел

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine("Число num1 равно числу num2");
}