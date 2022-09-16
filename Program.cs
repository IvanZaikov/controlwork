string[] CreatArrayString(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input element for array: ");
        newArray[i] = Convert.ToString(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreatArrayString(a);
ShowArray(myArray);
void narray(string[] Creatarray)
{
    for (int i = 0; i < Creatarray.Length; i++)

    {
        if (Creatarray[i].Length <= 3)
            Console.Write(Creatarray[i] + " ");

    }

    System.Console.WriteLine();
}
Console.WriteLine("new Array");
narray(myArray);