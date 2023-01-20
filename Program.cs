Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
int result = 0;
int MultiplicityNumber()
{
    result = Number1 % Number2;
    return result;
}
MultiplicityNumber();
System.Console.WriteLine();
if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {result}");
}
System.Console.WriteLine();