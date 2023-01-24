

String[] FillArray()
{
    int a = 3;
    String[] array = new String[a];
    for (int i = 0; i < a; i++)
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




