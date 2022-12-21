/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/

int[] GetArrayWithNumbers(int numberOfElements, int minDigit, int maxDigit)
{
    Random rnd = new Random();
    int[] arrey = new int[numberOfElements];
    for (int i = 0; i < numberOfElements; i++)
    {
        arrey[i] = rnd.Next(minDigit, maxDigit + 1);
    }
    return arrey;
}

int CountsEvenNumbers(int[] arrey)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] % 2 == 0) count ++;
    }
    return count;
}

void PrintArrey(int[] arrey)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length ; i++)
    {
        if (i == arrey.Length - 1)
            Console.Write(arrey[i]);
        else    
            Console.Write($"{arrey[i]}, ");
    }
    Console.Write("]");
}

int[] newArrey = GetArrayWithNumbers(8, 100, 999);
PrintArrey(newArrey);
Console.WriteLine($" -> {CountsEvenNumbers(newArrey)} ");