
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// НАЧАЛО КОДА ЗАДАЧИ 34

/*
int [] ZapolnjaemMassiva(int dlina)
{
    int [] array = new int[dlina];
    for (int i = 0; i < dlina; i++)
    {
        array[i] = new Random().Next (100, 1000);
    }
    return array;
}

void PechatMassiva(int [] arr)
{
    int count = arr.Length;
    for (int pos = 0; pos < count; pos++) Console.Write(arr[pos] + " ");
}

void Chetnije (int [] arr)
{
    int count = arr.Length;
    int schet = 0;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] % 2 == 0) schet += 1;
    }
    Console.WriteLine($"чётных чисел в массиве {schet} шт.");
}

Console.Clear();

Console.Write("введите размер массива -> ");
int razmer = Convert.ToInt32(Console.ReadLine());

int [] array = ZapolnjaemMassiva(razmer);
PechatMassiva(array);
Console.WriteLine();
Chetnije(array);
*/

// КОНЕЦ КОДА ЗАДАЧИ 34

//------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



//------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76