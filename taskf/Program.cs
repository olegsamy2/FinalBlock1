// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина //которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов в массиве A ");
int LengthA = Convert.ToInt32(Console.ReadLine());

string[] arrayA = new string[LengthA];
for (int i = 0; i < LengthA; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    arrayA[i] = Console.ReadLine()!;
}

string[] arrayB = new string[LengthA];
int sizeBEl = 3;                                   // длина элемента массива B
int j = 0;

for (int i = 0; i < LengthA; i++)
{
    if (arrayA[i].Length <= sizeBEl)
    {
        arrayB[j] = arrayA[i];
        j++;
    }
}

Console.WriteLine("Массив А(вводимый с клавиатуры): ");
PrintArray(arrayA);
Console.WriteLine("Массив B (на основе массива А, элементы которого не больше 3х по длине): ");
PrintArray(arrayB);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
