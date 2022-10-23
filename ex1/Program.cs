// Задание 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int num = new Random().Next(100,1000);

int second = num / 100;

int third = num / 100;
int result = second % 10;
Console.Write($" {num} ===> {result}");
