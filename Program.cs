string[] startArray = { "aaaaa", "a", "aa", "aaa", "aaaaaaa" };

string[] CreatNewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Count() <= 3)
        {
            j++;
        }
    }
    string[] newArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Count() <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string PrintStartArray(string[] array)
{
    string line = $"[\"{array[0]}\"";
    for (int i = 1; i < array.Length; i++)
    {
        line += $", \"{array[i]}\"";
    }
    line += "]";
    return line;
}

string PrintResultArray(string[] array)
{
    string res = string.Empty;
    if (array.Length > 0)
    {
        res = $"[\"{array[0]}\"";
        for (int i = 1; i < array.Length; i++)
        {
            res += $", \"{array[i]}\"";
        }
        res += "]";
    }
    else res = "[]";
    return res;
}

Console.Write(PrintStartArray(startArray));
Console.Write(" -> ");
Console.WriteLine(PrintResultArray(CreatNewArray(startArray)));