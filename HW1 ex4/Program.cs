//Программа, на входе принимает число (N), а на выходе показывает все четные числа от 1 до N.

System.Console.WriteLine("введите число N: ");
int a = int.Parse(Console.ReadLine());

Console.Write($"от 1 до  {a} - четные числа:");

for (int i = 1; i <=a; i++){
    if (i % 2 == 0){
        Console.Write(i + "  ");
    }
}
