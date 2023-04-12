//Программа, на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

System.Console.WriteLine("число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0){
    Console.WriteLine($"число {a} - четное.");
}
else{
    Console.WriteLine($"число {a} - не четное.");
}
