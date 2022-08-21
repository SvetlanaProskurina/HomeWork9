/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
string NumbersRecord (int m, int n)
{
    if (m<=n) return $"{m} " + NumbersRecord (m+1,n);
    else return String.Empty;
}
Console.WriteLine("Введите первое число больше 0");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число больше первого");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbersRecord(m,n));