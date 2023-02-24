// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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

double distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
}

int x1 = inputInt("Введите координату x первой точки");
int y1 = inputInt("Введите координату y первой точки");
int z1 = inputInt("Введите координату z первой точки");
int x2 = inputInt("Введите координату x второй точки");
int y2 = inputInt("Введите координату y второй точки");
int z2 = inputInt("Введите координату z второй точки");

System.Console.WriteLine($"Расстояние между точками с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance(x1, y1, z1, x2, y2, z2):f2}");
