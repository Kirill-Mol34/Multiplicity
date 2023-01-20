Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int result = 0;
int MultiplicityNumber()
{
    result = Num1 % Num2;
    return result;
}
MultiplicityNumber();
if (result == 0) System.Console.WriteLine($"Число {Num1} кратно числу {Num2}");
else
{
    Console.WriteLine($"Число {Num1} не кратно числу {Num2}, остаток от деления равен {result}");
}