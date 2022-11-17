// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int length = 4;
int[] massive = new int [length];
FillArray(massive);
PrintArray(massive);

void FillArray(int[] array, int minValue = 100 ,int maxValue = 999)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue,maxValue+1);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int count = 0;
for (int Z = 0; Z < massive.Length; Z++)
if (massive[Z] % 2 == 0)
count++;

Console.WriteLine($"всего {massive.Length} чисел, {count} из них чётные");