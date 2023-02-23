// // Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.WriteLine("Введите через пробел:");

string str = Console.ReadLine();
string[] array = str.Split(new Char[] {' '});

PrintArray(array);
Console.WriteLine();
PrintArray(FormingArray(array));
Console.WriteLine();

string[] FormingArray(string[] array)
{
    int countLarge = 0;
    for(var i = 0; i < array.Length; i++)    
    {       
        if(array[i].Length <= 3) 
        {
            countLarge++;
        }
    }
    
    string[] filteredArray = new string[countLarge];
    countLarge = 0;

    for(var i = 0; i < array.Length; i++)    
    {       
        if(array[i].Length <= 3) 
        {
            filteredArray[countLarge] = array[i];
            countLarge++;
        }
    } 
    return filteredArray;  
}

void PrintArray(string[] array)
{
    string str = string.Join(", ", array);
    Console.Write("[" + str + "]");  
}
