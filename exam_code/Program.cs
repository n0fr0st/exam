string[] arrayStr(int coll)
{
    string[] arr = new string[coll];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива.");
        arr[i] = Console.ReadLine();
        if (arr[i].Length == 0)
        {
            System.Console.WriteLine("Длина элемента массива должна быть больше 0.");
            i--;
        }
    }
    return arr;

}


void printArray(string[] array, int i)
{
    if (i == 1)
    {
        Console.WriteLine($"Введенный массив - [{string.Join(", ", array)}]");
    }
    else
    {
        Console.WriteLine($"Результирующий массив - [{string.Join(", ", array)}]");   
    }
}


string[] arrCheck(string[] collection)
{
    string[] coll = new string[0];
    int j = 0;
    for (int i =0; i < collection.Length; i++)
    {
        if (collection[i].Length <= 3)
        {
            Array.Resize(ref coll, coll.Length+1);
            coll[j] = collection[i];
            j++;
        }
    }
    return coll;
}

string[] array = arrayStr(4);
string[] resultArr = arrCheck(array);

for (int i = 1; i <=2; i++)
{
    string[] arr = new string[0];
    if (i==1)
    {
        Array.Resize(ref arr, array.Length);
        arr = array;
        printArray(arr, i);
    }
    else
    {
        Array.Resize(ref arr, resultArr.Length);
        arr = resultArr;
        printArray(arr, i);
    }
}
