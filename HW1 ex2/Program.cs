//Программа, принимает на вход три числа и выдает максимальное из этих чисел.

System.Console.WriteLine("число 1: ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("число 2: ");
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine("число 3: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (max<b){
    max = b;
}
if (max<c){
    max =c;
}
Console.WriteLine($"максимальное число {max}.");
