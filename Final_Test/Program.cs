// Написать программу, которая из имеющегося массива строк 
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
        line = temp + (char)new Random().Next(0x0021, 0x007E);
    }
    return line;
}




int max = 10;

int length = 5;

string[] lines = new string[length];

for (int i = 0; i < length; i++)
{
    lines[i] = FillLine(max);
}

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"\t{lines[i]}");
}





