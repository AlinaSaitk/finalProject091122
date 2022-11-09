string[] CreateArrayNSymbol(string[] array, int n)
{
    int len = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            len++;
        }
    }
    string[] newArr = new string[len];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= n)
        {
            newArr[k] = array[j];
            k++;
        }
    }
    return newArr;
}

// 2-й вариант:
// string[] CreateArrayNSymbol(string[] array, int n)
// {
//     string[] newArr = new string[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= n)
//         {
//             string[] newArrTemp = new string[newArr.Length + 1];
//             for (int j = 0; j < newArr.Length; j++)
//             {
//                 newArrTemp[j] = newArr[j];
//             }
//             newArrTemp[newArrTemp.Length-1] = array[i];
//             newArr = newArrTemp;
//         }
//     }
//     return newArr;
// }

void PrintArray(string[] array)
{
    if (array.Length != 0)
    {
        Console.Write($"[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine($"{array[array.Length - 1]}]");
    }
    else Console.WriteLine($"[]");
}


string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

string[] nArr1 = CreateArrayNSymbol(array1, 3);
PrintArray(nArr1);

string[] nArr2 = CreateArrayNSymbol(array2, 3);
PrintArray(nArr2);

string[] nArr3 = CreateArrayNSymbol(array3, 3);
PrintArray(nArr3);

