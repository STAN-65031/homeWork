// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int number2 = Convert.ToInt32(Console.ReadLine());

double Exponentiates(int num1, int num2)
{
    double expo = Math.Pow(num1, num2);
    return expo;
}

double result = Exponentiates(number1,number2);
Console.WriteLine(result);
