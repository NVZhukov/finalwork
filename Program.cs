
int ShortElement(string[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        int len = mass[i].Length;
        if (len <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] arr, int k)
{
    string[] mass = new string[k];
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int len = arr[i].Length;
        if (len <= 3)
        {
            mass[n] = arr[i];
            n++;
        }
    }
    return mass;
}

string[] arr = { "hello","22", "world", "haveaniceday", "))"};
string[] arr2 = {"Russia", "Denmark", "Kazan","DME"};
Console.Write("[");
Console.Write(String.Join(", ",NewArray(arr,ShortElement(arr))));
Console.Write("]");
Console.Write("[");
Console.Write(String.Join(", ",NewArray(arr2,ShortElement(arr2))));
Console.Write("]");