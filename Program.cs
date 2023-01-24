int a = 3;
String[] array = new String[a];

String[] FillArray()
{
    for (int i = 0; i <= a; i++)
    {
        Console.Write("Введите " + i + " элемент массива: ");
        //String element=Console.ReadLine()!;
        array[i] = Console.ReadLine()!;
    }
    return array;
}







