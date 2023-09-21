//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

void CreateArray(string? [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
     Console.Write($"Введите {i+1} элемент массива: ");
     array[i] =  Console.ReadLine();
  }
}

int CountElemLenTree(string [] array)
{
  int res = 0;
  for (int i = 0; i < array.Length; i++)
    if(array[i].Length <= 3)
        res++;
   return res;
}

void CreateNewArray(string [] array, string [] newArray)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k ++;
        }
}

void PrintArray(string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

Console.Write("Введите количество элементов массива исходного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] words = new string [n];
CreateArray(words);
Console.Write("Исходный массив: ");
PrintArray(words);
Console.WriteLine();
int count = CountElemLenTree(words);
if (count != 0)
{
    string [] newWords = new string [count];
    CreateNewArray(words, newWords);
    Console.Write("Результирующий массив: ");
    PrintArray(newWords);
}
else
    Console.Write("Результирующий массив: []");