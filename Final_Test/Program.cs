﻿// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string FillLine(int max)    // Генерация строки длиной от 1 до max состоящей из случайных символов Основной латиницы в Юникоде
{
    int number = new Random().Next(1, max);
    string temp;
    string line = String.Empty;
    for (int i = 0; i < number; i++)
    {
        temp = line;
        line = temp + (char)new Random().Next(0x0023, 0x007E);
    }
    return line;
}

int CountLengthFinalArray(string[] array)    // Нахождение длины финального массива
{
    int lengthFinal = 0;
    string temp = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i];
        if (temp.Length <= 3)
        {
            lengthFinal += 1;
        }
    }
    return lengthFinal;
}

int max = 10;
int length = 5;

string[] lines = new string[length];

for (int i = 0; i < length; i++)    // Заполняем массив случайными строками
{
    lines[i] = FillLine(max);
}

Console.Write("[");
for (int i = 0; i < length; i++)    // Вывод первоначального массива
{
    Console.Write(@$"""{lines[i]}""");
    if (i < length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");

int lengthFinal = CountLengthFinalArray(lines); // Получаем длину конечного массива
string[] linesFinal = new string[lengthFinal];

int j =0;
for (int i = 0; i < length; i++)    // Переносим в конечный массив подходящие по условию строки
{
    string temp = String.Empty;
    temp = lines[i];
    if (temp.Length <= 3)
    {
        linesFinal[j] = temp;
        j++;
    }
}

Console.Write($" --> [");
for (int i = 0; i < lengthFinal; i++)   // Выводим конечный массив
{
    Console.Write(@$"""{linesFinal[i]}""");
    if (i < lengthFinal - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");
