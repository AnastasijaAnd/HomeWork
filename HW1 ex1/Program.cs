// Программа, на вход принимает два числа и выдает, какое число большее, а какое меньшее.

System.Console.WriteLine("число 1: ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("число 2: ");
int b = int.Parse(Console.ReadLine());

if (a>b){
    Console.WriteLine($"большее число {a} , меньшее число {b}.");
}
else{
    Console.WriteLine($"большее число {b} , меньшее число {a}.");
}

