void CalcPosNeg(int[] array)
    {
        int sumPos = 0;
        int sumNeg = 0;

        void LocalFunction(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 1)
                {
                    sumNeg += arr[i];
                }
                else
                {
                    sumPos += arr[i];
                }
            }
        }

        LocalFunction(array);

        Console.WriteLine($"Summ of negative is {sumNeg} and summ positive is {sumPos}");
    }

   
    {
        int[] myArray = { -2, 5, -3, 8, 0, -1, 4, -6 };

        CalcPosNeg(myArray);
    }

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
    {
        int[] randomArray = GenerateRandomArray(4); 
        ShowArray(randomArray);

        int evenCount = CountEvenNumbers(randomArray);
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000); 
        }

        return array;
    }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

    static void ShowArray(int[] array)
    {
        Console.Write("Массив: [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

    {
        int[] randomArray = GenerateRandomArray(8);
        ShowArray(randomArray);

        int sum = SumOddPositions(randomArray);
        Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
    }

    int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(-100, 101); // Генерируем случайное число от -100 до 100
        }

        return array;
    }

    void ShowArray(int[] array)
    {
        Console.Write("Массив: [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    int SumOddPositions(int[] array)
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2) 
        {
            sum += array[i];
        }

        return sum;
    }


    {
        double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
        double difference = FindDifference(numbers);

        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }

    static double FindDifference(double[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Массив пуст.");
            return 0.0;
        }

        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }

            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max - min;
    }

