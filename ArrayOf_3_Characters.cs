Console.WriteLine();
Console.Write("Enter number of elements in your array: ");
int size = int.Parse(Console.ReadLine());
string[] array = new string[size];

FillArray(array);
PrintArray(array);
Console.Write(" -> ");
//PrintSelection3Sym(array); быстрый и простой способ, если нам не нужно нигде сохранить массив, а достаточно просто вывести
PrintArray(MakeSelection3Sym(array));



void FillArray(string[] arr)
{
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write("Enter word or number, element of array " + (i + 1) + ": ");
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    int l = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < l; i++)
    {
        if (i < l - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

void PrintSelection3Sym(string[] arr)
{
    int l = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < l; i++)
    {
        if (arr[i].Length <= 3)
        {
            if (i == 0) Console.Write(arr[i]);
            else Console.Write(", " + arr[i] + " ");
        }
    }
    Console.Write("]");
}

string[] MakeSelection3Sym(string[] arr)
{
    int l = arr.Length;
    int length = 0;
    for (int i = 0; i < l; i++)
    {
        if (arr[i].Length <= 3)
            length++;
    }

    string[] newArr = new string[length];
    length = 0;
    for (int i = 0; i < l; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[length] = arr[i];
            length++;
        }
    }
    return newArr;
}