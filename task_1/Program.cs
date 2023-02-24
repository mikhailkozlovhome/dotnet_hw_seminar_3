// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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

bool validateNumber (int numb)
{
    if (numb > 9999 && numb < 100000)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Введенное число не является пятизначным!");
        return false;
    }
}
int reverceNumber(int num)
{
    int dig;
    int revNum = 0;

    while (num > 0)
    {
        dig = num%10;
        revNum = revNum * 10 + dig;
        num /= 10;
    }
    return revNum;
}
bool isPolyndrom (int numb)
{
    int revNumb = reverceNumber(numb);
    if (revNumb == numb)
    {
        return true;    
    }
    return false;
}

int number = inputInt("Введите пятизначное число");
if (validateNumber(number))
{
    if (isPolyndrom(number))
    {
        System.Console.WriteLine($"Число {number} является полиндромом!");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является полиндромом!");
    }
}

