// Задача  
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] GetArray()
{
    string[] array = { "hello", "world", "345", "40", "commit" };
    return array;
}

string[] getNumbers(string[] numbers)
{
    string[] array = new string[0];
    foreach (var number in numbers)
    {
        if (number.Length <= 3) array = array.Append(number).ToArray();
    }
    System.Console.WriteLine();
    return array;
}
void main()
{
    string[] numbers = GetArray();
    System.Console.WriteLine();
    System.Console.WriteLine(string.Join(", ", numbers));
    string[] result = getNumbers(numbers);
    System.Console.WriteLine(string.Join(", ", result));
    System.Console.WriteLine();
}

main();