// Задача:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
// если вы выделяете ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито
// одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"]-> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->

string[] CreateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите слово, цифры или символы №{i+1}:  ");
        array[i] = Convert.ToString(Console.ReadLine()?? String.Empty);
    }
    return array;
}

void PrintArray(string[] array)
{
    System.Console.Write($"[{string.Join(", ", array)}]");
   
}

string[] CheckElements(string[] array, int length, int numberSigns)
{
    int j = 0;
    string[] arrayNew = new string[length];
    
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=numberSigns)
        {
            arrayNew[j]=array[i];
            j++;
        }
    }
    return arrayNew;
}


System.Console.Write("\nВведите кол-во элементов для проверки: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length<=0)
{
    System.Console.WriteLine($"\nОшибка! Кол-во элементов не может быть меньше 1.\n");
    return;
}

int numberSigns = 3;

string[] array=CreateArray(length);
System.Console.WriteLine($"\nИсходный массив:");
PrintArray(array);

System.Console.WriteLine($"\nМассив элементов, число символов которых = {numberSigns}:");
PrintArray(CheckElements(array, length, numberSigns));