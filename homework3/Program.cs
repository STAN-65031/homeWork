// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите числа через пробел");
string nums = Console.ReadLine();

// int[] ints = nums.Split(' ').Select(Int32.Parse).ToArray();
// for (int i = 0; i < ints.Length; i++)
// {
//     Console.WriteLine(ints[i]);
// }


int[] CreatesArrayNumbers (string numbers)
{
string[] ints = numbers.Split(' ');
int[] result = new int[ints.Length];

for (int i = 0; i < ints.Length; i++)
{
    int bag = Int32.Parse(ints[i]);
    result[i] = bag;
}
return result;
}

int[] resultArray = CreatesArrayNumbers(nums);

for (int i = 0; i < resultArray.Length; i++)
{
    Console.WriteLine(resultArray[i]);
}

