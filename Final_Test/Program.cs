// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int EnteringLength()          // Ввод размера матрицы
{
    Console.Write("Введите размер массива: ");
    int length;
    while (!int.TryParse(Console.ReadLine(), out length))
    {
        Console.Write("Ошибка ввода! Введите размер массива (введите целое число): ");
    }
    return length;
}

int EnteringMax()          // Ввод максимальной длины строки
{
    Console.Write("Введите максимальную длину строки: ");
    int max;
    while (!int.TryParse(Console.ReadLine(), out max))
    {
        Console.Write("Ошибка ввода! Введите максимальную длину строки (введите целое число): ");
    }
    return max;
}

int length = EnteringLength();

bool checkInputData1 = false;    // Проверка входных данных
while(checkInputData1 != true)
{
    if(length < 1)
    {
        Console.WriteLine("Размер массива не может быть отрицательным или равен 0");
        length = EnteringLength();
    }
    else
    {
        checkInputData1 = true;
    }
}

int max = EnteringMax();

bool checkInputData2 = false;    // Проверка входных данных
bool checkInputData3 = false;
while(checkInputData2 != true || checkInputData3 != true)
{
    if(max < 0)
    {
        Console.WriteLine("Длина строки не может быть отрицательной");
        max = EnteringMax();
        continue;
    }
    else
    {
        checkInputData2 = true;
    }
    if(max < 4)
    {
        Console.WriteLine("Если длина строки меньше 4-х, то в конечный массив перенесутся все строки. Задайте больший размер.");
        max = EnteringMax();
    }
    else
    {
        checkInputData3 = true;
    }
}

string FillLine(int max)    // Генерация строки длиной от 1 до max состоящей из случайных символов Основной латиницы в Юникоде
{
    int number = new Random().Next(0, max + 1); // Так как по условию и примерам не определено, то длина строки может быть и нулевой.
    string temp;                                // Соответственно, так как это удовлетворяет условиям задачи, то строки с 0-ой длиной
    string line = String.Empty;                 // будут перенесены в конечный массив и распечатаны
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
