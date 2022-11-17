// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int length = 4;
int[] massive = new int [length];
FillArray(massive);
PrintArray(massive);
int sum = 0;
for (int i = 0; i < massive.Length; i+=2)
sum = sum + massive[i];

Console.WriteLine($"всего {massive.Length} чисел, сумма элементов на нечётных позициях = {sum}");


void FillArray(int[] array, int minValue = 1 ,int maxValue = 100)
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

