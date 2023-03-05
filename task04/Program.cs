/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
массивами*/

string[] TheMainArray(string[] array) 
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarray = new string[count]; 
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

//string[] array = { "hello", "2", "world", ":-)" };
//string[] array = { "1234", "1567", "-2", "computer science" };
string[] array = { "Russia", "Denmark", "Kazan"};

Console.WriteLine();
Console.Write("Первоначальный массив: ");
PrintArray(array);
Console.WriteLine();

string[] newarray = TheMainArray(array);
Console.WriteLine("Строки, длина которых <= 3: ");
PrintArray(newarray);