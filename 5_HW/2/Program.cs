// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int size_mass = ReadInt("Размер массива: ");
int min = ReadInt("Минимальное возможное число массива: ");
int max = ReadInt("Максимальное возможное число массива: ");
int [] numbers = new int[size_mass];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i <= numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

// Методы задачи №2
    // Метод заполнения массива числами
    void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

    // Метод вывода массива
    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

// Функции задачи № 2
    // Функция ввода
    int ReadInt(string message)  
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }