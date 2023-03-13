/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами
*/


Console.Write("Введите элементы массива через пробел: ");
string[] initialArray = Console.ReadLine().Split(' ');

string[] resultArray = new string[initialArray.Length];
int count = 0;

for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        resultArray[count] = initialArray[i];
        count++;
    }
}

Console.Write("Массив строк длиной <= 3 символов: ");
for (int i = 0; i < count; i++)
{
    Console.Write(resultArray[i] + " ");
}
Console.WriteLine();


