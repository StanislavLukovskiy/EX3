// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

if (numberA % 2 == 0)
{
    Console.WriteLine(numberA + " Чётное");
}
else
{
    Console.WriteLine(numberA + " Нечётное");  
}