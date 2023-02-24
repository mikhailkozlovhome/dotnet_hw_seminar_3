// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int inputInt (string msg)
{
    int value;
    System.Console.Write($"{msg} -> ");
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Введенно неверное значение!");
    Environment.Exit(999);
    return 0;
}

int number = inputInt("Введите число");

System.Console.Write($"Таблица кубов числа {number} равна ->");
for (int i = 1; i <= number; i++)
{
    if (i < number)
    {
        System.Console.Write($" {i*i*i},");
    }
    else
    {
        System.Console.Write($" {i*i*i}");
    }
}
