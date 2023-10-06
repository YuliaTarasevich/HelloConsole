// Написать программу, которая сортирует заданный массив [1,5,7,8,93,45,67,83] в порядке убывания чисел.

int[] arr = { 1, 5, 7, 8, 93, 45, 67, 83, 105, 106, 106 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);



