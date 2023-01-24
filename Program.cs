

String[] FillArray()
{
    System.Console.Write("Введите количество элементов массива: ");
    int CountElements = int.Parse(Console.ReadLine()!);
    String[] array = new String[CountElements];
    for (int i = 0; i < CountElements; i++)
    {
        Console.Write("Введите " + i + " элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(String[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

String[] array = FillArray();
PrintArray(array);


String[] CheckArray(String[] array)
{
    int CountElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            CountElement++;
        }
    }
    String[] NewArray = new String[CountElement];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[i] = array[i];
        }
    }
    return NewArray;
}

String[] NewArray = CheckArray(array);
PrintArray(NewArray);



