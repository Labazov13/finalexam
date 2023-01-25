

String[] FillArray()
{
    System.Console.Write("Введите количество элементов массива: ");
    int CountElements = int.Parse(Console.ReadLine()!);
    String[] array = new String[CountElements];
    for (int i = 0; i < array.GetLength(0); i++)
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



String[] CheckArray(String[] array)
{
    int CountElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            CountElement++;     // 123 4465 78978 1
        }
    }
    System.Console.WriteLine();
    
    String[] NewArray = new String[CountElement];
    for (int b = 0, c = 0; b < array.GetLength(0); b++)
    {
        if (array[b].Length <= 3)
        {
            NewArray[c] = array[b];
            c++;
        }
    }
    return NewArray;
}


String[] array = FillArray();
PrintArray(array);

String[] NewArray = CheckArray(array);
PrintArray(NewArray);



