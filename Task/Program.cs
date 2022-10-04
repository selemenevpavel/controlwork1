// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] CreateArray = new string[] {};
Console.WriteLine("Введите через пробел строки массива");
string Rows = Console.ReadLine();
CreateArray = Rows.Split(' ');

// Задаем первый массив из строк, которые вводятся с клавиатуры через пробел

string[] ShowArray = new string[CreateArray.Length];

// Задаем второй массив, который будем показывать на основе первого после работы метода

void SecondArray(string[] CreateArray, string[] ShowArray)
{
    Console.WriteLine("Введите максимальную длину строки для вывода");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < CreateArray.Length; i++)
    {
        if (CreateArray[i].Length <= n)
        {
            ShowArray[i] = CreateArray[i];
        }
    }
}

// Задали метод, который на основании первого массива создает второй при условии максимального количества символов не больше n

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

// Задали метод, который выводит в консоль полученный массив в квадратных скобках

SecondArray(CreateArray, ShowArray);
PrintArray(ShowArray);