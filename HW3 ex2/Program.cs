/* ДЗ3 ЗАДАЧА 2  Программа, принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите координаты первой точки пространства в формате х,у,z: ");
string input1 = Console.ReadLine();
string[] splitInput1 = input1.Split(',');
int x1 = int.Parse(splitInput1[0]);
int y1 = int.Parse(splitInput1[1]);
int z1 = int.Parse(splitInput1[2]);

Console.WriteLine("Введите координаты второй точки пространства в формате х,у,z: ");
string input2 = Console.ReadLine();
string[] splitInput2 = input2.Split(',');
int x2 = int.Parse(splitInput2[0]);
int y2 = int.Parse(splitInput2[1]);
int z2 = int.Parse(splitInput2[2]);

Console.WriteLine($"Расстояние между точками равно: {Distance(x1, y1, z1, x2, y2, z2)}.");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}
