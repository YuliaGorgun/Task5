// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int length = 4;
double[] massive = new double[length];
FillArray(massive);
PrintArray(massive);
double min = int.MaxValue;
double max = int.MinValue;

for (int i = 0; i < massive.Length; i++)
 {
    if (massive[i] > max)
    {
        max = massive[i];
    }
    if (massive[i] < min)
    {
        min = massive[i];
    }
 }

Console.WriteLine($"всего {massive.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArray(double[] array)
{
var rnd = new Random();
for (int i = 0; i < array.Length; i++)
    {
        massive[i] = Convert.ToDouble(new Random().Next(10,100)) / 10;
    }
}
void PrintArray(double[] massive)
{
Console.Write("[ ");
for (int i = 0; i < massive.Length; i++)
    {
         Console.Write(massive[i] + " ");
    }
 Console.Write("]");
Console.WriteLine();
}       
