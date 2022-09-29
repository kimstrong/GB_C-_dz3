// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
string number = Convert.ToString(Console.ReadLine());
int number1 = number[0]; 
int number2 = number[1];
int number4 = number[3];
int number5 = number[4];
if (number1 == number5 && number2 == number4)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
