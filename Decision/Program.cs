string[] GetArray()
{
    Console.WriteLine("Введите значения для формирования первоначального массива через запятую : ");
    return Console.ReadLine().Split(", ");
}

int GetArrLength(string[] array, int n)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
            length++;
    }
    return length;
}

string[] FillNewArray(string[] firstArr, int n)
{
    string[] result = new string[GetArrLength(firstArr, n)];
    for (int i = 0, count = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i].Length <= n)
        {
            result[count] = firstArr[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

string[] firstArray = GetArray();
Console.Write("Первоначальный массив: ");
PrintArray(firstArray);
string[] newArray = FillNewArray(firstArray, 3);
Console.Write("Новый массив из строк, длина которых меньше либо равна 3 символам: ");
PrintArray(newArray);