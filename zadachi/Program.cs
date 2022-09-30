// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Task25()
{
    Console.Write("Введите первое число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int prod = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(power(numb, prod));
    int power(int Num, int prod)
    {
        int result = 1;
        for (int i = 0; i < prod; i++)
            result *= Num;
        return result;
    }
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Task27()
{
    int Summ(int num)
    {
        int result = 0;
        for (; num > 0; num /= 10)
            result = result + num % 10;
        return result;
    }
    Console.Write("Введите число: ");
    int numberN = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Сумма цифр в числе: " + Summ(numberN));
}



// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]
void Task29()
{
    int[] fillArray()
    {
        Random kit = new Random();
        int[] array = new int[8];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = kit.Next(-35, 35);
        }
        return array;
    }
    int[] Sort(int[] arr1)
    {
        for (int i = 0; i < arr1.Length; i++)
            for (int j = i; j < arr1.Length; j++)
                if (Math.Abs(arr1[j]) < Math.Abs(arr1[i]))
                {
                    int temp = arr1[j];
                    arr1[j] = arr1[i];
                    arr1[i] = temp;
                }
        return arr1;
    }
    void printArray(int[] arr2)
    {
        Console.Write("[ ");
        for (int i = 0; i < arr2.Length; i++)
            if (i < arr2.Length - 1)
                Console.Write(arr2[i] + ", ");
            else
                Console.Write(arr2[i]);
        Console.WriteLine(" ]");
    }
    int[] arrForSort = fillArray();
    printArray(arrForSort);
    Console.WriteLine("После сортировки по модулю: ");
    printArray(Sort(arrForSort));
}

// Task25();
// Task27();
Task29();

