/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.*/

//Метод для ввода массива с клавиатуры
string[] InputArray()
{
    System.Console.WriteLine("Введите число элементов в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

//Метод для выделения из массива элементов, состоящих из 3 или меньше символов
string[] SelectionArraysElements(string[] arr)
{
    int maxElementLenght = 3;
    int numberOfElement = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxElementLenght)
        {
            numberOfElement++;
        }
    }    
    string[] resultArray = new string[numberOfElement];
    int numberEl = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxElementLenght)
        {
            resultArray[numberEl] = arr[i];
            numberEl ++;
        }
    }
    return resultArray;
}

//Метод печати массива
void PrintArray(string[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}

//Вариант 1: массив задается пользователем с клавиатуры
string[] array = InputArray();
System.Console.WriteLine();
System.Console.Write("Массив , заданный с клавиатуры: ");
PrintArray(array);

string[] newArray = SelectionArraysElements(array);
System.Console.Write($"Элементы строк массива, заданного с клавиатуры, длина которых меньше либо равна 3 символа: ");
PrintArray(newArray);
System.Console.WriteLine();

//Вариант 2: массив задается внутри кода
string[] otherArray = {"222", "12", "sdfasf4"};
System.Console.Write($"Массив, заданный внутри кода: ");
PrintArray(otherArray);

string[] newOtherArray = SelectionArraysElements(otherArray);
System.Console.Write($"Элементы строк массива, заданного внутри кода, длина которых меньше либо равна 3 символа: ");
PrintArray(newOtherArray);