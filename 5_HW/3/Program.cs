// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size_mass = ReadInt("Размер массива: ");
int min = ReadInt("Минимально возможное число массива: ");
int max = ReadInt("Максимальное возможное число массива (плюс 1): "); // для 100 - ввод: 101
int [] numbers = new int[size_mass];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");


// Методы задачи № 3
    // Метод заполнения массива числами
    void FillArrayRandomNumbers(int [] array) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

    // Метод вывода
    void PrintArray(int[] array) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

// Функции задачи № 3
    // Функция ввода
    int ReadInt(string message) 
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }